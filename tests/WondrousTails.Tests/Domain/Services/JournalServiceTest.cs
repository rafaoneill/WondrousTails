using AutoFixture;
using Flurl.Http;
using Flurl.Http.Testing;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WondrousTails.Domain;
using WondrousTails.Domain.Implementations;
using WondrousTails.Domain.Response;
using Xunit;

namespace WondrousTails.Tests.Domain
{
    /// <summary>
    /// Set of tests for the JournalService
    /// </summary>
    public class JournalServiceTest
    {
        private JournalService _sut;

        private Fixture _fixture;
        private Mock<IAetherCurrentsClient> _mockClient;

        /// <summary>
        /// Test setup
        /// </summary>
        public JournalServiceTest()
        {
            _fixture = new Fixture();
            _mockClient = new Mock<IAetherCurrentsClient>();
        }

        /// <summary>
        /// Tests that the GetJournalSections method works
        /// </summary>
        [Trait("Domain", "Service")]
        [Trait("Service", "Journal")]
        [Trait("Page", "Journal")]
        [Fact]
        public void GetJournalSection_Works()
        {
            // arrange
            var journalSections = _fixture.CreateMany<JournalResponse>(3);
            _mockClient.Setup(s => s.GetResponse<JournalResponse>("journal", "sections")).Returns(Task.FromResult(journalSections));
            _sut = new JournalService(_mockClient.Object);

            // act
            var result = _sut.GetJournalSections();

            // assert
            Assert.Equal(3, result.Count());
            Assert.Equal(journalSections.Select(s => s.Id), result.Select(s => s.Id));
            Assert.Equal(journalSections.Select(s => s.Name), result.Select(s => s.Name));
        }
    }
}
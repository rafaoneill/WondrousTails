using AutoFixture;
using Flurl.Http.Testing;
using System;
using System.Collections.Generic;
using WondrousTails.Domain;
using Xunit;

namespace WondrousTails.Tests.Domain
{
    /// <summary>
    /// Set of tests for the AetherCurrentsClient
    /// </summary>
    public class AetherCurrentsClientTest
    {
        private AetherCurrentsClient _sut;

        private Fixture _fixture;

        /// <summary>
        /// Test setup
        /// </summary>
        public AetherCurrentsClientTest()
        {
            _fixture = new Fixture();
            var uri = new Uri("https://api.mysite.com");
            _sut = new AetherCurrentsClient(uri);
        }

        /// <summary>
        /// Tests that the Get method works
        /// </summary>
        [Fact]
        public void Get_WithoutParameters_Works()
        {
            using (var httpTest = new HttpTest())
            {
                // arrange
                var expected = _fixture.CreateMany<string>(3);
                httpTest.RespondWithJson(expected);

                // act
                var response = _sut.GetResponse<string>();

                // assert
                Assert.Equal(expected, response.Result);
            }
        }

        /// <summary>
        /// Tests that the Get method when provided an endpoint works
        /// </summary>
        [Fact]
        public void Get_WithEndPoint_Works()
        {
            using (var httpTest = new HttpTest())
            {
                // arrange
                var expected = _fixture.CreateMany<string>(3);
                httpTest.RespondWithJson(expected);

                // act
                var response = _sut.GetResponse<string>("something");

                // assert
                Assert.Equal(expected, response.Result);
            }
        }

        /// <summary>
        /// Tests that the Get method when provided multiple endpoints works
        /// </summary>
        [Fact]
        public void Get_WithMultipleEndPoints_Works()
        {
            using (var httpTest = new HttpTest())
            {
                // arrange
                var expected = _fixture.CreateMany<string>(3);
                httpTest.RespondWithJson(expected);

                // act
                var response = _sut.GetResponse<string>("something", "else");

                // assert
                Assert.Equal(expected, response.Result);
            }
        }
    }
}
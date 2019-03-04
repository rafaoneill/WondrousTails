using AutoMapper;
using AutoMapper.Configuration;
using SaintCoinach.Text;
using SaintCoinach.Xiv;
using System;
using WolvesDen.Profiles;
using Xunit;

namespace WolvesDen.Tests
{
    /// <summary>
    /// AutoMapper unit test for the JournalSection Profile
    /// </summary>
    [Collection("AutoMapper collection")]
    public class JournalSectionProfileTest
    {
        private AutoMapperFixture _fixture;

        /// <summary>
        /// Setup, initializes the Mapper
        /// </summary>
        /// <param name="fixture">The AutoMapperFixture object.</param>
        public JournalSectionProfileTest(AutoMapperFixture fixture)
        {
            _fixture = fixture;
        }

        /// <summary>
        /// Test that the mapping defined in the
        /// JournalSection Profile is valid
        /// </summary>
        [Fact]
        public void MappingConfigurationTest()
        {
            Mapper.Configuration.AssertConfigurationIsValid<JournalSectionProfile>();
        }
    }
}
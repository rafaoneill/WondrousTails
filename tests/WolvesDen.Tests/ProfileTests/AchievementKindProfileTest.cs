using AutoMapper;
using AutoMapper.Configuration;
using System;
using WolvesDen.Profiles;
using Xunit;

namespace WolvesDen.Tests
{
    /// <summary>
    /// AutoMapper unit test for the AchievementKindProfile
    /// </summary>
    [Collection("AutoMapper collection")]
    public class AchievementKindProfileTest
    {
        private AutoMapperFixture _fixture;

        /// <summary>
        /// Setup, initializes the Mapper
        /// </summary>
        public AchievementKindProfileTest(AutoMapperFixture fixture)
        {
           _fixture = fixture;
        }

        /// <summary>
        /// Test that the mapping defined in the
        /// AchievementKind Profile is valid
        /// </summary>
        [Fact]
        public void MappingConfigurationTest()
        {
            Mapper.Configuration.AssertConfigurationIsValid<AchievementKindProfile>();
        }
    }
}
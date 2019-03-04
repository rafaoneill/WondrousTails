using AutoMapper;
using AutoMapper.Configuration;
using System;
using WolvesDen.Profiles;
using Xunit;

namespace WolvesDen.Tests
{
    /// <summary>
    /// AutoMapper unit test for the AchievementProfile
    /// </summary>
    [Collection("AutoMapper collection")]
    public class AchievementProfileTest
    {
        private AutoMapperFixture _fixture;

        /// <summary>
        /// Setup, initializes the Mapper
        /// </summary>
        /// <param name="fixture">The AutoMapperFixture object.</param>
        public AchievementProfileTest(AutoMapperFixture fixture)
        {
           _fixture = fixture;
        }

        /// <summary>
        /// Test that the mapping defined in the
        /// Achievement Profile is valid
        /// </summary>
        [Fact]
        public void MappingConfigurationTest()
        {
            Mapper.Configuration.AssertConfigurationIsValid<AchievementProfile>();
        }
    }
}
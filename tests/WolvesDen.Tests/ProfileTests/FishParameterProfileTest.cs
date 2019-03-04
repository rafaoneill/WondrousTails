using AutoMapper;
using AutoMapper.Configuration;
using System;
using WolvesDen.Profiles;
using Xunit;

namespace WolvesDen.Tests
{
    /// <summary>
    /// AutoMapper unit test for the FishParameterProfile
    /// </summary>
    [Collection("AutoMapper collection")]
    public class FishParameterProfileTest
    {
        private AutoMapperFixture _fixture;

        /// <summary>
        /// Setup, initializes the Mapper
        /// </summary>
        /// <param name="fixture">The AutoMapperFixture object.</param>
        public FishParameterProfileTest(AutoMapperFixture fixture)
        {
            _fixture = fixture;
        }

        /// <summary>
        /// Test that the mapping defined in the
        /// FishParameter Profile is valid
        /// </summary>
        [Fact]
        public void MappingConfigurationTest()
        {
            Mapper.Configuration.AssertConfigurationIsValid<FishParameterProfile>();
        }
    }
}
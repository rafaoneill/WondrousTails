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
    /// AutoMapper unit test for the Orchestrion Profile
    /// </summary>
    [Collection("AutoMapper collection")]
    public class OrchestrionProfileTest
    {
        private AutoMapperFixture _fixture;

        /// <summary>
        /// Setup, initializes the Mapper
        /// </summary>
        /// <param name="fixture">The AutoMapperFixture object.</param>
        public OrchestrionProfileTest(AutoMapperFixture fixture)
        {
            _fixture = fixture;
        }

        /// <summary>
        /// Test that the mapping defined in the
        /// Orchestrion Profile is valid
        /// </summary>
        [Fact]
        public void MappingConfigurationTest()
        {
            Mapper.Configuration.AssertConfigurationIsValid<OrchestrionProfile>();
        }
    }
}
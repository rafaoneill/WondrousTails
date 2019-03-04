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
    /// AutoMapper unit test for the ActionComboRouteTransient Profile
    /// </summary>
    [Collection("AutoMapper collection")]
    public class ActionComboRouteTransientProfileTest
    {
        private AutoMapperFixture _fixture;

        /// <summary>
        /// Setup, initializes the Mapper
        /// </summary>
        /// <param name="fixture">The AutoMapperFixture object.</param>
        public ActionComboRouteTransientProfileTest(AutoMapperFixture fixture)
        {
            _fixture = fixture;
        }

        /// <summary>
        /// Test that the mapping defined in the
        /// ActionComboRouteTransient Profile is valid
        /// </summary>
        [Fact]
        public void MappingConfigurationTest()
        {
            Mapper.Configuration.AssertConfigurationIsValid<ActionComboRouteTransientProfile>();
        }
    }
}
using AutoMapper;
using System;
using WolvesDen;

namespace WolvesDen.Tests
{
    /// <summary>
    /// The AutoMapperFixture class to register and unregister AutoMapper mappings.
    /// </summary>
    public sealed class AutoMapperFixture : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the AutoMapperFixture class.
        /// </summary>
        public AutoMapperFixture()
        {
            AutoMapperConfig.RegisterMappings();
        }

        /// <summary>
        /// Disposes of the AutoMapper definition.
        /// </summary>
        public void Dispose()
        {
            Mapper.Reset();
        }
    }
}
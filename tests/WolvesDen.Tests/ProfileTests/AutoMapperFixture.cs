using AutoMapper;
using System;
using WolvesDen;

namespace WolvesDen.Tests
{
    public class AutoMapperFixture : IDisposable
    {
        public AutoMapperFixture()
        {
            AutoMapperConfig.RegisterMappings();
        }

        public void Dispose()
        {
            Mapper.Reset();
        }
    }
}
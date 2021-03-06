using Xunit;

namespace WolvesDen.Tests
{
    /// <summary>
    /// The AutoMapperCollection class.
    /// </summary>
    [CollectionDefinition("AutoMapper collection")]
    public class AutoMapperCollection : ICollectionFixture<AutoMapperFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
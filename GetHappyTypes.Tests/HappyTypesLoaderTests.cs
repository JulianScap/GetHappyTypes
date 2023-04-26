namespace GetHappyTypes.Tests;

public class HappyTypesLoaderTests
{
    [Fact]
    public void DoWork_ShouldWork()
    {
        List<IHappyInterface> result = HappyTypesLoader.DoWork();
        Assert.NotEmpty(result);
    }
}

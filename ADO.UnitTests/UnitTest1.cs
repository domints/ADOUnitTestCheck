using ADO.Api;

namespace ADO.UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }

    [Fact]
    public void Test2()
    {
        Assert.True(false);
    }

    [Fact]
    public void TestRandomNumber()
    {
        var stuffer = new Stuffer();

        var result = stuffer.GetRandomNumber();

        Assert.Equal(4, result);
    }

    [Fact]
    public void TestRandomNumberFail()
    {
        var stuffer = new Stuffer();

        var result = stuffer.GetRandomNumber();

        Assert.Equal(5, result);
    }
}
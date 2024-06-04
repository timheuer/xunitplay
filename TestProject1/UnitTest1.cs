using Xunit.Abstractions;

namespace TestProject1;

public class UnitTest1
{
    private ITestOutputHelper _output;

    public UnitTest1(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void Test1()
    {
        _output.WriteLine("Test1");
        Assert.True(false);
    }
}
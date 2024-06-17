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
    public void Failed_XUnit_Test()
    {
        _output.WriteLine("This xUnit test failed");
        Assert.True(false);
    }

    [Fact]
    public void Passed_XUnit_Test()
    {
        _output.WriteLine("This xUnit test passed");
        Assert.True(true);
    }
}
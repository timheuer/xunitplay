using Xunit.Abstractions;

namespace TestProject1;

public class UnitTest1
{
    private ITestOutputHelper _output;
    readonly PrimeLibrary.Class1 _primeService;

    public UnitTest1(ITestOutputHelper output)
    {
        _output = output;
        _primeService = new PrimeLibrary.Class1();
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

    [Theory]
    [InlineData(-1), InlineData(0), InlineData(1)]
    public void IsPrime_ValuesLessThan2_ReturnFalse(int value) =>
        Assert.False(_primeService.IsPrime(value), $"{value} should not be prime");

    [Theory]
    [InlineData(2), InlineData(3), InlineData(5), InlineData(7), InlineData(11)]
    public void IsPrime_PrimesLessThan10_ReturnTrue(int value) =>
        Assert.True(_primeService.IsPrime(value), $"{value} should be prime");

    [Theory]
    [InlineData(4), InlineData(6), InlineData(8), InlineData(9)]
    public void IsPrime_NonPrimesLessThan10_ReturnFalse(int value) =>
        Assert.False(_primeService.IsPrime(value), $"{value} should not be prime");
}
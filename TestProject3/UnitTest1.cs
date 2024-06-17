namespace TestProject3;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void NUnit_Failed_Test()
    {
        Console.WriteLine("This nUnit test failed.");
        Assert.Fail();
    }

    [Test]
    public void NUnit_Passing_Test()
    {
        Console.WriteLine("This nUnit test passed.");
        Assert.Pass();
    }
}
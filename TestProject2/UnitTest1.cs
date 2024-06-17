namespace TestProject2;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void MSTest_Failed_Test()
    {
        Console.WriteLine("This MSTest failed");
        Assert.IsTrue(false);
    }

    [TestMethod]
    public void MSTest_Passing_Test()
    {
        Console.WriteLine("This MSTest failed");
        Assert.IsTrue(true);
    }
}
namespace TestMSTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Add_One_Plus_One()
    {
        var mathResult = 1 + 1;
        Assert.AreEqual(2, mathResult);
    }
}
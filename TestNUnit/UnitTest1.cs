namespace TestNUnit;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Add_One_Plus_One()
    {
        var mathResult = 1 + 1;
        Assert.That(mathResult, Is.EqualTo(2));
    }
}
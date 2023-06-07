namespace TestXUnit;

public class UnitTest1
{
    [Fact]
    public void Add_One_Plus_One()
    {
        var mathResult = 1 + 1;
        Assert.Equal(2, mathResult);
    }
}
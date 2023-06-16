namespace TestXUnit;

public class MathTests
{
    [Theory]
    [InlineData(1,2,3)]
    [InlineData(-4,-6,-10)]
    [InlineData(-2,2,0)]
    public void CanAddTheory(int val1, int val2, int expected)
    {
        var result =  val1 + val2;
        Assert.Equal(expected, result);
    }
}

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

    [Theory]
    [MemberData(nameof(Data))]
    internal void CanAddTheoryMemberDataProperty(int val1, int val2, int expected)
    {
        var result = val1 + val2;
        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(GetData), parameters: 3)]
    internal void CanAddTheoryMemberDataMethod(int val1, int val2, int expected)
    {
        var result = val1 + val2;
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> Data =>
    new List<object[]>
    {
        new object[] { 1, 2, 3},
        new object[] { -4, -6, -10 },
        new object[] { -2, 2, 0 }
    };

    public static IEnumerable<object[]> GetData(int numTests)
    {
        var allData = new List<object[]>
        {
            new object[] { 1, 2, 3 },
            new object[] { -4, -6, -10 },
            new object[] { -2, 2, 0 },
        };

        return allData.Take(numTests);
    }
}

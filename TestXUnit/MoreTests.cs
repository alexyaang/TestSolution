using TestClassLib;

namespace TestXUnit;

public class MoreTests
{
public static IEnumerable<object[]> InternalData => new List<object[]>
    {
        new object[] 
        {
            new ItemA { Id = 1, Name = "Bob" },
            new ItemB { Age = 12, Location = "USA" },
            new ItemC { Id = 1, Name = "Bob", Age = 12, Location = "USA" },
        },
        new object[] 
        {
            new ItemA { Id = 2, Name = "Bob" },
            new ItemB { Age = 12, Location = "USA" },
            new ItemC { Id = 2, Name = "Bob", Age = 12, Location = "USA" },
        },
        new object[] 
        {
            new ItemA { Id = 3, Name = "Bob" },
            new ItemB { Age = 12, Location = "USA" },
            new ItemC { Id = 3, Name = "Bob", Age = 12, Location = "USA" },
        },
        new object[] 
        {
            new ItemA { Id = 4, Name = "Bob" },
            new ItemB { Age = 12, Location = "USA" },
            new ItemC { Id = 4, Name = "Bob", Age = 12, Location = "USA" },
        },
        new object[] 
        {
            new ItemA { Id = 5, Name = "Bob" },
            new ItemB { Age = 12, Location = "USA" },
            new ItemC { Id = 5, Name = "Bob", Age = 12, Location = "USA" },
        },
    };

    [Theory]
    [MemberData(nameof(InternalData))]
    internal void Test1(ItemA itemA, ItemB itemB, ItemC itemC)
    {
        // Arrange
        var worker = new Worker();

        // Act
        ItemC actual = worker.DoSomething(itemA, itemB);

        // Assert
        actual.Should().BeEquivalentTo(itemC);
    }
}

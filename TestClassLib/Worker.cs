namespace TestClassLib;

internal class Worker
{
    public ItemC DoSomething(ItemA itemA, ItemB itemB) => new()
    {
        Id = itemA.Id,
        Name = itemA.Name,
        Age = itemB.Age,
        Location = itemB.Location
    };
}

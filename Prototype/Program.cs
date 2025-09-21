// See https://aka.ms/new-console-template for more information

using Prototype;

var p1 = new Person
{
    Age = 42,
    Name = "Jack Daniels",
    IdInfo = new IdInfo(666),
    BirthDate = Convert.ToDateTime("1977-01-01"),
};

var p2 = p1.ShallowCopy();
var p3 = p1.DeepCopy();

p1.IdInfo = new IdInfo(777);
p3.Name = "Edward Northon";

Console.WriteLine("   p1 instance values: ");
Console.WriteLine(p1);
Console.WriteLine("   p2 instance values:");
Console.WriteLine(p2);
Console.WriteLine("   p3 instance values:");
Console.WriteLine(p3);
// See https://aka.ms/new-console-template for more information

using EquelsExample;

Test1 test1 = new Test1()
{
    Name = "Test1",
    Id = "1"
};

Test2 test2 = new Test2()
{
    Name = "Test1",
    Id = "1"
};

bool result = test1.Equals(test2);
if (test1 == test2)
{
    
}
Console.WriteLine("Hello, World!");
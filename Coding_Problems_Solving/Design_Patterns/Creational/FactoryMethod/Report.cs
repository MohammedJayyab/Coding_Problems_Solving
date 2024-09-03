//Step 2: Implement Concrete Products

namespace Coding_Problems_Solving.Design_Patterns.Creational.FactoryMethod;

public class Report : Document
{
    public void Print()
    {
        Console.WriteLine("Printing Report");
    }
}
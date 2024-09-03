using Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory2.products;

namespace Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory2.factories;

public abstract class Company
{
    public abstract IGpu CreateGpu();

    public abstract IMonitor CreateMonitor();

    protected void LogCreation(string productType)
    {
        Console.WriteLine($"{productType} has been created by {this.GetType().Name}");
    }
}
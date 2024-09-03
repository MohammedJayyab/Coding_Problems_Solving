using Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory2.products;

namespace Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory2.factories;

public class MsiManufacturer : Company
{
    public override IGpu CreateGpu()
    {
        LogCreation("CreateGpu");
        return new MsiGpu();
    }

    public override IMonitor CreateMonitor()
    {
        LogCreation("CreateMonitor");
        return new MsiMonitor();
    }
}
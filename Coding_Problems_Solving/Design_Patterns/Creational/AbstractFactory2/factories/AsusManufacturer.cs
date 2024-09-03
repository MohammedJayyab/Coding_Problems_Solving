using Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory2.products;

namespace Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory2.factories;

public class AsusManufacturer : Company
{
    public override IGpu CreateGpu()
    {
        return new AsusGpu();
    }

    public override IMonitor CreateMonitor()
    {
        return new AsusMonitor();
    }
}
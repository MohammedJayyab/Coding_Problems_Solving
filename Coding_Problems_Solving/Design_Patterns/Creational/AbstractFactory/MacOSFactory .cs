namespace Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory;

// Concrete Factory 2
public class MacOSFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacOSButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacOSCheckbox();
    }
}
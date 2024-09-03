namespace Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory;

// Concrete Factory 1
public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }
}
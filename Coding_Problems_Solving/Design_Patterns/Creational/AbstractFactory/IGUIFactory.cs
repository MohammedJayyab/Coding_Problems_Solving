namespace Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory;

// The Abstract Factory interface declares a set of methods that return different abstract products.
public interface IGUIFactory
{
    IButton CreateButton();

    ICheckbox CreateCheckbox();
}
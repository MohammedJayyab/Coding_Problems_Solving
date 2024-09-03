namespace Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory;

// Concrete Product B2
public class MacOSCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("MacOS Checkbox Painted");
    }
}
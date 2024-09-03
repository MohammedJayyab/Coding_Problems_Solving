namespace Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory;

// Concrete Product B1
public class WindowsCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Windows Checkbox Painted");
    }
}
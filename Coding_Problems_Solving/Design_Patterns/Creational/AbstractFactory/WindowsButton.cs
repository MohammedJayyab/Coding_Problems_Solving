namespace Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory;

// Concrete Product A1
public class WindowsButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Windows Button Painted");
    }
}
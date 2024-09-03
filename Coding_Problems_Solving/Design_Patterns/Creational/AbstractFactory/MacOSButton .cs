namespace Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory;

// Concrete Product A2
public class MacOSButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("MacOS Button Painted");
    }
}
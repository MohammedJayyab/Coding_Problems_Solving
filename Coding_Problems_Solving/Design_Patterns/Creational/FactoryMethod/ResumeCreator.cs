namespace Coding_Problems_Solving.Design_Patterns.Creational.FactoryMethod;

// A 'ConcreteCreator' class
public class ResumeCreator : DocumentCreator
{
    public override Document CreateDocument()
    {
        return new Resume();
    }
}
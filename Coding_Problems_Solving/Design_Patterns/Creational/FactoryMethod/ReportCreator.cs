namespace Coding_Problems_Solving.Design_Patterns.Creational.FactoryMethod;

// Another 'ConcreteCreator' class
public class ReportCreator : DocumentCreator
{
    public override Document CreateDocument()
    {
        return new Report();
    }
}
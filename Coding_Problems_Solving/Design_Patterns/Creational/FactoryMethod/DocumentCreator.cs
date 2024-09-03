//Step 3: Define the Creator Class
namespace Coding_Problems_Solving.Design_Patterns.Creational.FactoryMethod;

// The 'Creator' abstract class
public abstract class DocumentCreator
{
    // The factory method
    public abstract Document CreateDocument();

    // The operation which uses the factory method
    public void PrintDocument()
    {
        // Call the factory method to create a Product object
        Document doc = CreateDocument();
        doc.Print();
    }
}
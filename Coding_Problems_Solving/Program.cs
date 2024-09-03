using Coding_Problems_Solving.Design_Patterns.Behavioral.Strategy;
using Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory;
using Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory2.factories;
using Coding_Problems_Solving.Design_Patterns.Creational.AbstractFactory2.products;
using Coding_Problems_Solving.Design_Patterns.Creational.FactoryMethod;
using Coding_Problems_Solving.Design_Patterns.Singleton;
using System;
using System.Linq;
using System.Runtime.Intrinsics.X86;

public class Program
{
    public static void Main()
    {
        //  Use the Factory Method

        // Create and print a resume
        /*
         * DocumentCreator creator = new ResumeCreator();
        creator.PrintDocument();

        // Create and print a report
        creator = new ReportCreator();
        creator.PrintDocument();

        Console.ReadLine();
        */

        // Use the Abstract Factory
        // The client code works with any concrete factory class.
        /* IGUIFactory factory;

         // Here the choice of the factory is made at runtime depending on some configuration or environment setting.
         string os = "Windows"; // Could also be "MacOS"

         if (os == "Windows")
         {
             factory = new WindowsFactory();
         }
         else
         {
             factory = new MacOSFactory();
         }

         // Create the application with the selected factory.
         Application app = new Application(factory);
         app.Paint();
          */

        /* Company msi = new MsiManufacturer();
         Company asus = new AsusManufacturer();

         IGpu msiGpu = msi.CreateGpu();
         msiGpu.Assymble();
         //msi.LogCreation("Gpu");

         Console.ReadLine();
          */

        // User selects a payment method
        IPaymentStrategy paymentStrategy;

        Console.WriteLine("Choose a payment method: 1. Credit Card  2. PayPal  3. Bitcoin");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                paymentStrategy = new CreditCardPayment("1234567812345678");
                break;

            case "2":
                paymentStrategy = new PayPalPayment("user@example.com");
                break;

            case "3":
                paymentStrategy = new BitcoinPayment("1FfmbHfnpaZjKFvyi1okTjJJusN455paPH");
                break;

            default:
                throw new NotSupportedException("Payment method not supported");
        }

        // Create an order and process the payment
        Order order = new Order(paymentStrategy);
        order.ProcessOrder(150.00m);

        // Accessing the Singleton instance
        Singleton singleton = Singleton.Instance;

        // Calling a method on the Singleton instance
        singleton.DoSomething();

        Console.ReadLine();
        /*   int[] arr = { 1, 23, 8, 100 };
           var result = string.Join("", arr.Select(n => n.ToString())
                                           .OrderByDescending(s => s, new CustomComparer()));
           Console.WriteLine(result); // Expected Output: 8231100
        */
    }
}

public class CustomComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        string order1 = x + y;
        string order2 = y + x;
        return order1.CompareTo(order2);
    }
}
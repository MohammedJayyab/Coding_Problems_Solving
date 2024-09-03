using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems_Solving.Design_Patterns.Singleton;

public class Singleton
{
    // Private static variable to hold the single instance of the class
    private static Singleton _instance;

    // Lock object for thread safety
    private static readonly object _lock = new object();

    // Private constructor to prevent instantiation
    private Singleton()
    {
    }

    // Public static method to provide access to the instance
    public static Singleton Instance
    {
        get
        {
            // Double-checked locking to ensure thread safety and avoid unnecessary locking
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }

    // Example method that can be called on the Singleton instance
    public void DoSomething()
    {
        Console.WriteLine("Singleton instance method called.");
    }
}
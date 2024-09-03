namespace Coding_Problems_Solving.Design_Patterns.Behavioral.Strategy;

// Concrete Strategy C: Bitcoin Payment
public class BitcoinPayment : IPaymentStrategy
{
    private readonly string _walletAddress;

    public BitcoinPayment(string walletAddress)
    {
        _walletAddress = walletAddress;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} using Bitcoin wallet {_walletAddress}.");
    }
}
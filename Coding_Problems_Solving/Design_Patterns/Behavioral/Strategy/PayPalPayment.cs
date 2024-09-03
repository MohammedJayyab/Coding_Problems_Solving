namespace Coding_Problems_Solving.Design_Patterns.Behavioral.Strategy;

// Concrete Strategy B: PayPal Payment
public class PayPalPayment : IPaymentStrategy
{
    private readonly string _email;

    public PayPalPayment(string email)
    {
        _email = email;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} using PayPal account {_email}.");
    }
}
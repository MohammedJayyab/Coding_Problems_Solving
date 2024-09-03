namespace Coding_Problems_Solving.Design_Patterns.Behavioral.Strategy;

// Concrete Strategy A: Credit Card Payment
public class CreditCardPayment : IPaymentStrategy
{
    private readonly string _cardNumber;

    public CreditCardPayment(string cardNumber)
    {
        _cardNumber = cardNumber;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} using Credit Card ending in {_cardNumber.Substring(_cardNumber.Length - 4)}.");
    }
}
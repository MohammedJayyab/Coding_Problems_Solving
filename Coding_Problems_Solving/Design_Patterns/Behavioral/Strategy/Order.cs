namespace Coding_Problems_Solving.Design_Patterns.Behavioral.Strategy;

public class Order
{
    private readonly IPaymentStrategy _paymentStrategy;

    public Order(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void ProcessOrder(decimal amount)
    {
        _paymentStrategy.Pay(amount);
    }
}
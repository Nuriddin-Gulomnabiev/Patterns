using Adapter.Interfaces;

namespace Adapter.Payments;

public class PayPalPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"PayPal payment processing... amount: {amount}");
    }
}
using Adapter.Interfaces;

namespace Adapter.Payments;

public class SquarePayment : ISquarePayment
{
    public void MakePayment(decimal amount, string currency)
    {
        Console.WriteLine($"Square payment processing... amount: {amount}, currency: {currency}");
    }
}
using Adapter.Interfaces;

namespace Adapter.Adapters;

public class SquareAdapter : IPaymentProcessor
{
    private readonly ISquarePayment _payment;
    
    public SquareAdapter(ISquarePayment payment)
    {
        _payment = payment;
    }
    
    public void ProcessPayment(decimal amount)
    {
        _payment.MakePayment(amount, "USD");
    }
}
using Adapter.Interfaces;

namespace Adapter.Adapters;

public class StripeAdapter : IPaymentProcessor
{
    private readonly IStripePayment _payment;
    
    public StripeAdapter(IStripePayment payment)
    {
        _payment = payment;
    }
    
    public void ProcessPayment(decimal amount)
    {
        _payment.ChargeCustomer((int)(amount * 100));
    }
}
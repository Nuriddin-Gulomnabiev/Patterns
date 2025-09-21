using Adapter.Interfaces;

namespace Adapter.Payments;

public class StripePayment : IStripePayment
{
    public void ChargeCustomer(int amountInCents)
    {
        Console.WriteLine($"Stripe payment processing... amount: {amountInCents}");
    }
}
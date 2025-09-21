namespace Adapter.Interfaces;

public interface IStripePayment
{
    void ChargeCustomer(int amountInCents);
}
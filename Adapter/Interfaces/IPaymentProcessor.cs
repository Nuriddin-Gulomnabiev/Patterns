namespace Adapter.Interfaces;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}
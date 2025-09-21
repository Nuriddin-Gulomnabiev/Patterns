using Adapter.Interfaces;

namespace Adapter.Services;

public class TransactionService
{
    private readonly IPaymentProcessor _paymentProcessor;
    
    public TransactionService(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public void Pay(decimal amount)
    {
        _paymentProcessor.ProcessPayment(amount);
    }
}
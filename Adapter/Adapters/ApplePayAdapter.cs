using Adapter.Interfaces;

namespace Adapter.Adapters;

public class ApplePayAdapter :  IPaymentProcessor
{
    private readonly IApplePayPayment _payment;
    private readonly string _userToken;

    public ApplePayAdapter(IApplePayPayment payment, string userToken)
    {
        _payment = payment;
        _userToken = userToken;
    }
    
    public void ProcessPayment(decimal amount)
    {
        _payment.SendPayment(amount, _userToken);
    }
}
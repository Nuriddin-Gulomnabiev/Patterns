using Adapter.Interfaces;

namespace Adapter.Payments;

public class ApplePayPayment : IApplePayPayment
{
    public void SendPayment(decimal amount, string userToken)
    {
        Console.WriteLine($"Apple payment processing... amount: {amount}, userToken: {userToken}");
    }
}
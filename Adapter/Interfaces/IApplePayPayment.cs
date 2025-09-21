namespace Adapter.Interfaces;

public interface IApplePayPayment
{
    void SendPayment(decimal amount, string userToken);
}
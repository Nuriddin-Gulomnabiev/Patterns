using FactoryMethod.FactoryMethod.Attributes;
using FactoryMethod.FactoryMethod.Interfaces;

namespace FactoryMethod.FactoryMethod.Products;

[PayType("paypal")]
public class PayPal : IPayMethod
{
    public void Pay(decimal amount) =>  Console.WriteLine("PayPal Pay " + amount);
}
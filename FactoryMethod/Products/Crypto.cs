using FactoryMethod.FactoryMethod.Attributes;
using FactoryMethod.FactoryMethod.Interfaces;

namespace FactoryMethod.FactoryMethod.Products;

[PayType("crypto")]
public class Crypto : IPayMethod
{
    public void Pay(decimal amount) => Console.WriteLine("Crypto Pay " + amount);
}
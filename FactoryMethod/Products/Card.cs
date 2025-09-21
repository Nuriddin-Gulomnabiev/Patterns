using FactoryMethod.FactoryMethod.Attributes;
using FactoryMethod.FactoryMethod.Interfaces;

namespace FactoryMethod.FactoryMethod.Products;

[PayType("card")]
public class Card : IPayMethod
{
    public void Pay(decimal amount) => Console.WriteLine("Card Pay " + amount);
}
using System.Reflection;
using FactoryMethod.FactoryMethod.Attributes;
using FactoryMethod.FactoryMethod.Interfaces;

namespace FactoryMethod.FactoryMethod.Factories;

public class PayFactory
{
    private readonly Dictionary<string, Type> _payMethods;
    
    public PayFactory()
    {
        _payMethods = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(IPayMethod).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .Select(t => new
            {
                Type = t,
                Attr = t.GetCustomAttribute<PayTypeAttribute>()
            })
            .Where(x => x.Attr != null)
            .ToDictionary(x => x.Attr!.Type, x => x.Type);
    }

    public IPayMethod CreatePayMethod(string type)
    {
        if (!_payMethods.TryGetValue(type.ToLower(), out var deliverType))
            throw new ArgumentException($"Неизвестный способ платежа: {type}");

        return (IPayMethod)Activator.CreateInstance(deliverType)!;
    }
}
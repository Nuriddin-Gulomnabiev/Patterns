namespace FactoryMethod.FactoryMethod.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class PayTypeAttribute : Attribute
{
    public string Type { get; }

    public PayTypeAttribute(string type)
    {
        Type = type.ToLower();
    }
}
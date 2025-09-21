using Builder.Products;

namespace Builder.Builders;

public class PizzaBuilder
{
    private Pizza _pizza = new  Pizza();

    public PizzaBuilder WithSize(string size)
    {
        _pizza.Size = size;
        return this;
    }

    public PizzaBuilder WithSauce(string sauce)
    {
        _pizza.Sauce = sauce;
        return this;
    }

    public PizzaBuilder AddTopping(params string[] top)
    {
        _pizza.Top.AddRange(top);
        return this;
    }

    public PizzaBuilder IsCheeseCrust(bool isCheeseCrust)
    {
        _pizza.IsCheeseCrust = isCheeseCrust;
        return this;
    }
    
    public Pizza Build()
    {
        var result = _pizza;
        
        _pizza = new Pizza();
        
        return result;
    }
}
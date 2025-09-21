
var pizza = new PizzaBuilder()
    .WithSize("Средняя")
    .WithSauce("Сырный")
    .AddTopping("огурцы", "грибы")
    .IsCheeseCrust(false)
    .Build();

Console.WriteLine(pizza.ToString());


public class Pizza
{
    public string Size { get; set; } 
    public string Sauce { get; set; }
    public List<string> Top { get; set; } = new List<string>();
    public bool IsCheeseCrust { get; set; }

    public override string ToString()
    {
        return $"Пицца: размер={Size}, соус={Sauce}, начинка=[{string.Join(",", Top)}], бортик={(IsCheeseCrust ? "Сырной" : "Обычный")}";
    }
}

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


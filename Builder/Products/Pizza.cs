namespace Builder.Products;

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
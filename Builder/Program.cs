using Builder.Builders;

var pizza = new PizzaBuilder()
    .WithSize("Средняя")
    .WithSauce("Сырный")
    .AddTopping("огурцы", "грибы")
    .IsCheeseCrust(false)
    .Build();

Console.WriteLine(pizza);


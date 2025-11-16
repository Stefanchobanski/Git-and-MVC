using System.ComponentModel.DataAnnotations;

namespace StockExchange;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }
    
    public void Display()
    {
        Console.Write("Цена за килограм на зеленчуци лв: ");
        double priceVegetable = double.Parse(Console.ReadLine());

        Console.Write("Цена за килограм на плодове лв: ");
        double priceFruts = double.Parse(Console.ReadLine());

        Console.Write("Колко кг имаш от зеленчуците: ");
        int kgVegetable = int.Parse(Console.ReadLine());

        Console.Write("Колко кг имаш от плодовете: ");
        int kgFruts = int.Parse(Console.ReadLine());

        Model model = new Model(priceVegetable, priceFruts, kgVegetable, kgFruts);

        string result = _controller.Calculate(model);
        Console.WriteLine(result);
    }
}

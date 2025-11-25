using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace StockExchange;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void InputConsole()
    {
        Console.Write("Цена за килограм на зеленчуци лв: ");
        string priceVegetable = Console.ReadLine();

        Console.Write("Цена за килограм на плодове лв: ");
        string priceFruts = Console.ReadLine();

        Console.Write("Колко кг имаш от зеленчуците: ");
        string kgVegetable = Console.ReadLine();

        Console.Write("Колко кг имаш от плодовете: ");
        string kgFruts = Console.ReadLine();

        Display(priceVegetable, priceFruts, kgVegetable, kgFruts);
    }

    public string Display(string priceVegetable, string priceFruts, string kgVegetable, string kgFruts)
    {
        bool state = HandleEx(priceVegetable, priceFruts, kgVegetable, kgFruts);

        if (!state)
        {
            Model model = new Model(double.Parse(priceVegetable), double.Parse(priceFruts), int.Parse(kgVegetable), int.Parse(kgFruts));

            string result = _controller.Calculate(model);
            Console.WriteLine(result);

            return result;
        }
        return "";
    }

    public void ThrowsEx(string priceVegetable, string priceFruts, string kgVegetable, string kgFruts)
    {
        double priceVeg = double.Parse(priceVegetable);
        double priceFrut = double.Parse(priceFruts);
        int kmVeg = int.Parse(kgVegetable);
        int kmFrut = int.Parse(kgFruts);

        if(priceVeg < 0 || priceFrut < 0 || kmVeg < 0 || kmFrut < 0)
        {
            throw new Exception("Негативно число");
        }
    }

    private bool HandleEx(string priceVegetable, string priceFruts, string kgVegetable, string kgFruts)
    {
        bool state = false;
        try
        {
            ThrowsEx(priceVegetable, priceFruts, kgVegetable, kgFruts);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            state = true;
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
            state = true;
        }
        return state;
    }
}

using System.Data;

namespace PriceForTransport;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void Display()
    {
        Console.Write("Колко километра ще пътуваш?: ");
        string km = Console.ReadLine();

        Console.Write("Ден или нощ е ?: ");
        string timeDay = Console.ReadLine();

        bool state = Handle(km, timeDay);

        if (!state)
        {

            Model model = new Model(int.Parse(km), timeDay);

            string result = _controller.Calculate(model);
            Console.WriteLine(result);
        }

    }
    
    public void ThrowsEx(string inputKm, string inputTimeDay)
    {
        int km = 0;

        km = int.Parse(inputKm);

        if (inputTimeDay.ToLower() != "day" && inputTimeDay.ToLower() != "night")
        {
            throw new Exception("Невалиден вход за част от деня");
        }
        if (km < 0)
        {
            throw new Exception("Негативни КМ");
        }
    }

    private bool Handle(string inputKm, string inputTimeDay)
    {
        bool state = false;

        int km = 0;
        string timeDay = "";

        try
        {
            ThrowsEx(inputKm, inputTimeDay);
        }
        catch (FormatException ex)
        {
            state = true;
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            state = true;
            Console.WriteLine(ex.Message);
        }
        return state;
    }
}


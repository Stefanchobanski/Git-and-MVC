namespace Adventure;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void InputConsole()
    {
        Console.Write("Бюджет: ");
        string buget = Console.ReadLine();

        Console.Write("Сезон summer - winter: ");
        string season = Console.ReadLine();

        Display(buget, season);
    }

    public string Display(string buget, string season)
    {
        bool state = HandleEx(buget, season);

        if (!state)
        {
            Model model = new Model(double.Parse(buget), season);

            string result = _controller.Output(model);

            Console.WriteLine(result);

            return result;
        }
        return "";
    }

    public void ThrowEx(string buget, string season)
    {
        double b = double.Parse(buget);

        if(b < 0)
        {
            throw new Exception("Негативно число");
        }

        if(season.ToLower() != "winter" && season.ToLower() != "summer")
        {
            throw new Exception("Невалиден сезон");
        }
    }

    private bool HandleEx(string buget, string season)
    {
        bool state = false;
        try
        {
            ThrowEx(buget, season);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            state = true;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            state = true;
        }

        return state;
    }
}

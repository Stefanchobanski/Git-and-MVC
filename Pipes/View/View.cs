namespace Pipes;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void InputConsole()
    {
        Console.Write("Обема на басейна: ");
        string v = Console.ReadLine();

        Console.Write("Дебита на първата тръба: ");
        string p1 = Console.ReadLine();

        Console.Write("Дебита на втората тръба: ");
        string p2 = Console.ReadLine();

        Console.Write("Колко часа ще се пълни: ");
        string hours = Console.ReadLine();

        Display(v, p1, p2, hours);
    }

    public string Display(string v, string p1, string p2, string hours)
    {
        bool state = HandleEx(v, p1, p2, hours);

        if (!state)
        {
            Model model = new Model(int.Parse(v), int.Parse(p1), int.Parse(p2), double.Parse(hours));

            string results = _controller.Result(model);
            Console.WriteLine(results);

            return results;
        }
        return "";
    }

    public void ThrowEx(string v, string p1, string p2, string hours)
    {
        int volume = int.Parse(v);
        int pCuurent1 = int.Parse(p1);
        int pCuurent2 = int.Parse(p2);
        double h = double.Parse(hours);

        if (volume < 0 || pCuurent1 < 0 || pCuurent2 < 0 || h < 0)
        {
            throw new Exception("Негативно число");
        }
    }

    private bool HandleEx(string v, string p1, string p2, string hours)
    {
        bool state = false;
        try
        {
            ThrowEx(v, p1, p2, hours);
        }
        catch(FormatException ex)
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

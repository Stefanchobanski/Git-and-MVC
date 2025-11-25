namespace TileRepair;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void InputConsole()
    {
        Console.Write("Дължината на страната от площадката: ");
        string n = Console.ReadLine();

        Console.Write("Широчина на една  плочка: ");
        string w = Console.ReadLine();

        Console.Write("Дължина на една плочка: ");
        string l = Console.ReadLine();

        Console.Write("Широчина на пейката: ");
        string m = Console.ReadLine();

        Console.Write("Дължина на пейката: ");
        string o = Console.ReadLine();

        Display(n, w, l, m, o);
    }

    public string Display(string n, string w, string l, string m, string o)
    {
        bool state = Handle(n, w, l, m, o);

        if (!state)
        {
            Model model = new Model(int.Parse(n), double.Parse(w), double.Parse(l), int.Parse(m), int.Parse(o));
            string result = _controller.Result(model);

            Console.WriteLine(result);
            return result;
        }
        return "";
    }

    public void TrowsEx(string n, string w, string l, string m, string o)
    {
        int n1 = int.Parse(n);
        double w1 = double.Parse(w);
        double l1 = double.Parse(l);
        int m1 = int.Parse(m);
        int o1 = int.Parse(o);

        if(n1 < 0 || w1 < 0 || l1 < 0 || m1 < 0 || o1 < 0)
        {
            throw new Exception("Негативно число");
        }
    }

    private bool Handle(string n, string w, string l, string m, string o)
    {
        bool state = false;

        try
        {
            TrowsEx(n, w, l, m, o);
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

namespace PasswordGenerator;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void InputConsole()
    {
        Console.Write("Въведи N: ");
        string n = Console.ReadLine();

        Console.Write("Въведи L: ");
        string l = Console.ReadLine();

        Display(n, l);
    }

    public string Display(string n, string l)
    {
        bool state = _HandleEx(n, l);

        if (!state)
        {
            Model model = new Model(int.Parse(n), int.Parse(l));

            string result = _controller.Password(model);
            Console.WriteLine(result);
            
            return result;
        }
        return "";
    }

    public void ThrowEx(string n, string l)
    {
        int a = int.Parse(n);
        int b = int.Parse(l);

        if (a < 0 || b < 0)
        {
            throw new Exception("Негативно число");
        }
    }

    private bool _HandleEx(string n, string l)
    {
        bool state = false;
        try
        {
            ThrowEx(n, l);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            state = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            state = true;
        }
        return state;
    }
}

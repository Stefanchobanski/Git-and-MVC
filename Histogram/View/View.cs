namespace Histogram;

public class View
{
    Controller _controller;
    Model _model;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void InputConsole()
    {
        List<string> items = new List<string>();

        Console.Write("Колко числа искаш да добавиш: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write("Въведи число: ");
            items.Add(Console.ReadLine());
        }

        DisplayOutput(items);
    }

    public string DisplayOutput(List<string> items)
    {
        bool state = HandleEx(items);

        if (!state)
        {
            Model model = new Model(items.Select(int.Parse).ToList());
            _model = model;

            string result = _controller.GetStatus(_model);
            Console.WriteLine(result);
            return result;
        }
        return "";
    }


    public void ThrowsEx(List<string> list)
    {
        foreach (string item in list)
        {
            double number = double.Parse(item);

            if (number < 0)
            {
                throw new Exception("Негативно число");
            }
        }
    }

    private bool HandleEx(List<string> list)
    {

        bool state = false;

        try
        {
            ThrowsEx(list);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void InputConsole()
    {
        Console.Write("Въведи магическо число: ");
        string magicNumber = Console.ReadLine();

        Display(magicNumber);
    }

    public string Display(string magic)
    {
        bool state = HandleEx(magic);

        if (!state)
        {
            Model model = new Model(int.Parse(magic));

            string result = _controller.Result(model);

            Console.WriteLine(result);

            return result;
        }
        return "";
    }

    public void ThrowEx(string number)
    {
        int magic = int.Parse(number);
    }

    private bool HandleEx(string number)
    {
        bool state = false;
        try
        {
            ThrowEx(number);
        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
            state = true;
        }
        return state;
    }
}

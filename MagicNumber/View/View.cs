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
    public void Display()
    {
        Console.Write("Въведи магическо число: ");
        int magicNumber = int.Parse(Console.ReadLine());

        Model model = new Model(magicNumber);

        string result = _controller.Result(model);

        Console.WriteLine(result);
    }
}

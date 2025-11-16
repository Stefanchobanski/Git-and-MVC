namespace Pipes;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void Display()
    {
        Console.Write("Обема на басейна: ");
        int v = int.Parse(Console.ReadLine());

        Console.Write("Дебита на първата тръба: ");
        int p1 = int.Parse(Console.ReadLine());

        Console.Write("Дебита на втората тръба: ");
        int p2 = int.Parse(Console.ReadLine());

        Console.Write("Колко часа ще се пълни: ");
        double hours = double.Parse(Console.ReadLine());

        Model model = new Model(v, p1, p2, hours);

        string results = _controller.Result(model);
        Console.WriteLine(results);
    }
}

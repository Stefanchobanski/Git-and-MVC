namespace TileRepair;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void Display()
    {
        Console.Write("Дължината на страната от площадката: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Широчина на една  плочка: ");
        double w = double.Parse(Console.ReadLine());

        Console.Write("Дължина на една плочка: ");
        double l = double.Parse(Console.ReadLine());

        Console.Write("Широчина на пейката: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Дължина на пейката: ");
        int o = int.Parse(Console.ReadLine());

        Model model = new Model(n, w, l, m, o);

        string result = _controller.Result(model);

        Console.WriteLine(result);
    }
}

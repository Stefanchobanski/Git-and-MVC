namespace Devide;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void Display()
    {
        List<int> list = new List<int>();

        Console.Write("Въведи колко числа ще напишеш: ");
        int count = int.Parse(Console.ReadLine());

        for(int i = 0; i < count; i++)
        {
            Console.Write("Въведи число: ");
            list.Add(int.Parse(Console.ReadLine()));
        }

        Model model = new Model(list);

        string result = _controller.Result(model);

        Console.WriteLine(result);
    }
}

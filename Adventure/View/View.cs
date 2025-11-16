namespace Adventure;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void Display()
    {
        Console.Write("Бюджет: ");
        double buget = double.Parse(Console.ReadLine());

        Console.Write("Сезон summer - winter: ");
        string season = Console.ReadLine();

        Model model = new Model(buget, season);

        string result = _controller.Output(model);

        Console.WriteLine(result);
    }
}

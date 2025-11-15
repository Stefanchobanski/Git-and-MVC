namespace PriceForTransport;

public class View
{
    Controller _controller;
    public View(Controller controller)               
    {
        _controller = controller;
    }

    public void Display()
    {
        Console.Write("Колко километра ще пътуваш?: ");
        int km = int.Parse(Console.ReadLine());

        Console.Write("Ден или нощ е ?: ");
        string timeDay = Console.ReadLine();

        Model model = new Model(km ,timeDay);

        string result = _controller.Calculate(model);
        Console.WriteLine(result);
    }
}   

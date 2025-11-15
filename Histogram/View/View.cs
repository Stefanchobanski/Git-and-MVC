namespace Histogram;

public class View
{
    Controller _controller ;
    Model _model;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void DisplayInput()
    {
        List<int> items = new List<int>();

        Console.Write("Колко числа искаш да добавиш: ");
        int count = int.Parse(Console.ReadLine());

        for(int i = 0; i < count; i++)
        {
            Console.Write("Въведи число: ");
            items.Add(int.Parse(Console.ReadLine()));
        }

        Model model = new Model(items);
        _model = model;
    }

    public void DisplayOutput() {
        Console.WriteLine(_controller.GetStatus(_model)); 
    }
}

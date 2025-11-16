namespace PasswordGenerator;

internal class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void Display()
    {
        Console.Write("Въведи N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Въведи L: ");
        int l = int.Parse(Console.ReadLine());

        Model model = new Model(n, l);

        Console.WriteLine(_controller.Password(model));
    }
}

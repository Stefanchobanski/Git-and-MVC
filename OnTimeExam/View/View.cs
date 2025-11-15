namespace OnTimeExam;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public void Display()
    {
        Console.Write("В колко часа почва изпита: ");
        int hourExercise = int.Parse(Console.ReadLine());

        Console.Write("В колко минути почва изпита: ");
        int minExercise = int.Parse(Console.ReadLine());

        Console.Write("В колко часа пристигаш: ");
        int ariveTimeHour = int.Parse(Console.ReadLine());

        Console.Write("В колко минути пристигаш: ");
        int ariveTimeMin = int.Parse(Console.ReadLine());

        Model model = new Model(hourExercise, minExercise, ariveTimeHour, ariveTimeMin);

        string result = _controller.Calculate(model);
        Console.WriteLine(result);
    }
}

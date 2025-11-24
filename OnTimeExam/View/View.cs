namespace OnTimeExam;

public class View
{
    Controller _controller;
    public View(Controller controller)
    {
        _controller = controller;
    }

    public string Display(string hourExercise, string minExercise, string ariveTimeHour, string ariveTimeMin)
    {

        bool state = Check(hourExercise, minExercise, ariveTimeHour, ariveTimeMin);

        if (!state)
        {
            Model model = new Model(int.Parse(hourExercise), int.Parse(minExercise), int.Parse(ariveTimeHour), int.Parse(ariveTimeMin));

            string result = _controller.Calculate(model);
            Console.WriteLine(result);

            return result;
        }
        return "";
    }

    public void InputConsole()
    {
        Console.Write("В колко часа почва изпита: ");
        string hourExercise = Console.ReadLine();

        Console.Write("В колко минути почва изпита: ");
        string minExercise = Console.ReadLine();

        Console.Write("В колко часа пристигаш: ");
        string ariveTimeHour = Console.ReadLine();

        Console.Write("В колко минути пристигаш: ");
        string ariveTimeMin = Console.ReadLine();

        Display(hourExercise, minExercise, ariveTimeHour, ariveTimeMin);
    }

    public void ThrowsEx(string currentHourExercise, string currentMinExercise, string currentAriveTimeHour, string currentAriveTimeMin)
    {
        int hourExercise = int.Parse(currentHourExercise);
        int minExercise = int.Parse(currentMinExercise);
        int hourArrive = int.Parse(currentAriveTimeHour);
        int minArrive = int.Parse(currentAriveTimeMin);

        if (hourArrive < 0 || minExercise < 0 || hourExercise < 0 || minArrive < 0)
        {
            throw new Exception("Негативни данни");
        }
        if (minArrive >= 60 || minExercise >= 60)
        {
            throw new Exception("Въведени минути повече от 60");
        }
        if (hourArrive > 24 || hourExercise > 24)
        {
            throw new Exception("Въведен час повече от 24");
        }
    }

    private bool Check(string hourExercise, string minExercise, string ariveTimeHour, string ariveTimeMin)
    {
        bool state = false;
        try
        {
            ThrowsEx(hourExercise, minExercise, ariveTimeHour, ariveTimeMin);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Невалиден формат");
            state = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            state = true;
        }

        return state;
    }
}

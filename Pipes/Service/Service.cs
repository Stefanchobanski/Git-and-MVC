namespace Pipes;

public class Service
{
    public string Calculate(Model model)
    {
        string result = "";

        double p1Sum = model.p1 * model.Hours;
        double p2Sum = model.p2 * model.Hours;

        double all = p1Sum + p2Sum;

        if (all <= model.Volume)
        {
            result = $"The pool is {Math.Floor(all / model.Volume * 100)}% full. Pipe 1: {Math.Floor(p1Sum / all * 100)}%. Pipe 2: {Math.Floor(p2Sum / all * 100)}%.";
        }
        else
        {
            result = $"For {model.Hours} hours the pool overflows with {Math.Floor(all - model.Volume)} liters.";
        }

        return result;
    }
}

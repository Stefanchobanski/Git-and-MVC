namespace Devide;

public class Controller
{
    Service _service;
    public Controller(Service service)
    {
        _service = service;
    }

    public string Result(Model model )
    {
        string result = "";



        Dictionary<int, int> dict = _service.Calculate(model);
        double count = model.Items.Count;
        foreach (var item in dict) {
            result += $"{item.Value / count * 100:F2}%\n";
        }
        return result;
    }
}

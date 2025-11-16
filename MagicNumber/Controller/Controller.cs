namespace MagicNumber;

public class Controller
{
    Service _service;
    public Controller(Service service)
    {
        _service = service;
    }
    public string Result(Model model)
    {
        string result = "";

        foreach (var item in _service.Generator(model)) {
            result += item + "\n";
        }
        return result;
    }
}

namespace PasswordGenerator;

public class Controller
{
    Service _service;

    public Controller(Service service)
    {
        _service = service;
    }

    public string Password(Model model)
    {
        string _results = "";

        List<string> lists = _service.GeneratePass(model);

        foreach (string item in lists) { 
            _results += item + "\n";
        }

        return _results;
    }
}


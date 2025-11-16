using System.Xml;

namespace Adventure;

public class Controller
{
    Service _service;

    public Controller(Service service)
    {
        _service = service;
    }

    public string Output(Model model)
    {
       return _service.Result(model);
    }
}

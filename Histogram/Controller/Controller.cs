namespace Histogram;

public class Controller
{
    Service _service;
    
    public Controller(Service service)
    {
        _service = service;
    }

    public string GetStatus(Model model)
    {
        return _service.Status(model);
    }
}

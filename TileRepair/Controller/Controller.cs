namespace TileRepair;

public class Controller
{
    Service _service;
    public Controller(Service service)
    {
        _service = service;
    }

    public string Result(Model model)
    {
        return _service.Calculate(model);
    }
}

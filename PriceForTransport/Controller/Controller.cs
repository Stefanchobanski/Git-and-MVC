namespace PriceForTransport;

public class Controller
{
    ServiceCalculate _service;

    public Controller(ServiceCalculate service)
    {
        _service = service;
    }

    public string Calculate(Model model)
    {
        return _service.Calculate(model);
    }
}

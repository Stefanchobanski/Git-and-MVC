namespace OnTimeExam;

public class Controller
{
    Service _service;
    public Controller(Service service)
    {
        _service = service;
    }

    public string Calculate(Model model)
    {
       return _service.Calculate(model);
    }
}

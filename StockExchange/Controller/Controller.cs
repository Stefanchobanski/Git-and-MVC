namespace StockExchange;

public class Controller
{
    Service _service;
    public Controller(Service service)
    {
        _service = service;
    }

    public string Calculate(Model model)
    {
        double price = _service.CalculateIncome(model);
        return "Общата цена е: " + price.ToString() + " евро." ;
    }
}

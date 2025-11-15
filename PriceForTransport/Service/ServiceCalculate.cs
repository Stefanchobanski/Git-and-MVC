namespace PriceForTransport;

public class ServiceCalculate
{
    double _result = 0;
    public string Calculate(Model model)
    {
        int km = model.Km;
        List<Transport> transports = model.Transports;
        string timeDay = model.TimeDate;

        if (km < 20)
        {
            _result = transports[0].FirstTax;

            if (timeDay == "day")
            {
                _result += km * transports[0].PriceDay;
            }
            else if (timeDay == "night")
            {
                _result += km * transports[0].PriceNight;
            }
        }
        else if (km < 100)
        {
            _result = km * transports[1].PriceDay;
        }
        else
        {
            _result = km * transports[2].PriceDay;
        }

            return $"{_result:F2}";
    }
}

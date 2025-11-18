namespace PriceForTransport;

public class ServiceCalculate
{
    Model _model;
    public string Calculate(Model model)
    {
        _model = model;

        int km = model.Km;
        List<Transport> transports = model.Transports;
        string timeDay = model.TimeDate;

        if (km < 100 && km >= 20)
        {
            model.Transports[1].AllPrice = km * transports[1].PriceDay;
        }
        else if (km >= 100)
        {
            model.Transports[2].AllPrice = km * transports[2].PriceDay;
        }


        model.Transports[0].AllPrice = transports[0].FirstTax;

        if (timeDay == "day")
        {
            model.Transports[0].AllPrice += km * transports[0].PriceDay;
        }
        else if (timeDay == "night")
        {
            model.Transports[0].AllPrice += km * transports[0].PriceNight;
        }


        return $"{GetLowerTax().AllPrice:F2}";
    }


    private Transport GetLowerTax()
    {
        Transport transportLow = _model.Transports[0];

        foreach (var item in _model.Transports)
        {
            if((item.AllPrice < transportLow.AllPrice ) && item.AllPrice != 0)
            {
                transportLow = item;
            }
        }
        return transportLow;
    }
}

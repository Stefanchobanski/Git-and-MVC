namespace PriceForTransport;

public class Bus : Transport
{
    public Bus(string timeDay)
    {
        Name = "Автобус";
        PriceDay = 0.09;
        PriceNight = 0.09;
        FirstTax = 0;
        MinKm = 20;
    }
}

namespace PriceForTransport;

public class Taxi : Transport
{
    public Taxi(string timeDay) {
        Name = "Такси";
        PriceDay = 0.79;
        PriceNight = 0.90;
        FirstTax = 0.7;
        MinKm = 0;
    }
}

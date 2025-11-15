using System.Xml.Linq;

namespace PriceForTransport;

public class Train : Transport
{
    public Train(string timeDay)
    {
        Name = "Влак";
        PriceDay = 0.06;
        PriceNight = 0.06;
        FirstTax = 0;
        MinKm = 100;
    }
}

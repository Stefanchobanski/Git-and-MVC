namespace PriceForTransport;

public class Model
{
    public List<Transport> Transports = new List<Transport>();
    public int Km = 0;
    public string TimeDate = "";
    public Model(int km, string dayTime)
    {
        Transports.Add(new Taxi(dayTime));
        Transports.Add(new Bus(dayTime));
        Transports.Add(new Train(dayTime));

        Km = km;
        TimeDate = dayTime;
    }
}

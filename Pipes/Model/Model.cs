namespace Pipes;

public class Model
{
    public int Volume;
    public int p1;
    public int p2;
    public double Hours;

    public Model(int volume, int p1, int p2, double hours)
    {
        Volume = volume;
        this.p1 = p1;
        this.p2 = p2;
        Hours = hours;
    }
}

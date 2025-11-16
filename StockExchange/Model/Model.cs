namespace StockExchange;

public class Model
{
    public double PriceVegetable;
    public double PriceFruts;
    public int KgVegetable;
    public int KgFruts;

    public Model(

        double priceVegetable, double priceFruts, int kgVegetable, int kgFruts)
    {
        PriceVegetable = priceVegetable;
        PriceFruts = priceFruts;
        KgVegetable = kgVegetable;
        KgFruts = kgFruts;
    }
}

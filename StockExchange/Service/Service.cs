namespace StockExchange;

public class Service
{
    public double CalculateIncome(Model model)
    {
        double result = 0;

        double priceVeg = model.PriceVegetable;
        double priceFruts = model.PriceFruts;
        int kgVeg = model.KgVegetable;
        int kgFruts = model.KgFruts;

        result = (priceVeg * kgVeg) + (priceFruts * kgFruts);
        result = Math.Round(result / 1.94, 2);
        return result ;
    }
}

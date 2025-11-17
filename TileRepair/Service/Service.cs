namespace TileRepair;

public class Service
{
    public string Calculate(Model model)
    {
        string result = "";

        int allSumArea = model.N * model.N;
        int allSumBench = model.M * model.O;

        int areaCover = allSumArea - allSumBench;

        double allTileArea = model.W * model.L;

        double requiredTiles = areaCover / allTileArea;

        double needTime = requiredTiles * 0.2;

        result = requiredTiles + "\n" + needTime;

        return result;
    }
}

namespace Histogram;

public class Model
{

    public Dictionary<int, int> SortedItems = new Dictionary<int, int>()
    {
        { 199, 0 },
        { 399, 0 },
        { 599, 0 },
        { 799, 0 },
        { int.MaxValue, 0 },
    };

    public List<int> AllItems;

    public Model(List<int> allItems)
    {
        AllItems = allItems;
    }
}

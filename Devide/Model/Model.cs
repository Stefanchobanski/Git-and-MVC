namespace Devide;

public class Model
{
    public Dictionary<int, int> Dict;
    public List<int> Items;

    public Model(List<int> items)
    {
        Dict = new Dictionary<int, int>()
        {
            { 2, 0 },
            { 3, 0 },
            { 4, 0 },
        };
        Items = items;
    }
}

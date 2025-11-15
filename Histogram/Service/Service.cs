namespace Histogram;

public class Service
{
    public string Status(Model model)
    {
        Dictionary<int, int> _dict = model.SortedItems;
        List<int> _items = model.AllItems;

        string _result = "";
        double _countAll = _items.Count;

        foreach (var item in _items)
        {
            foreach (var currentDict in _dict)
            {
                if (item <= currentDict.Key)
                {
                    _dict[currentDict.Key] ++;
                    break;
                }
            }

        }

        foreach (var item in _dict) {
            _result += $"{item.Value / _countAll * 100:F2}%\n";
        }

        return _result;
    }
}

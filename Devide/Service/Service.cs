namespace Devide;

public class Service
{
    public Dictionary<int,int> Calculate(Model model)
    {
        foreach ( var item in model.Items)
        {
            foreach (var dict in model.Dict)
            {
                if(item % dict.Key == 0)
                {
                    model.Dict[dict.Key]++;
                }
            }   
        }
        return model.Dict;
    }
}

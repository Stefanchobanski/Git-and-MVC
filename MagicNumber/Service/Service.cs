namespace MagicNumber;

public class Service
{
    public List<string> Generator(Model model)
    {
        List<string> result = new List<string>();

        for(int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int x = 1; x <= 9; x++)
                {
                    for (int y = 1; y <= 9; y++)
                    {
                        for (int h = 1; h <= 9; h++)
                        {
                            for (int z = 1; z <= 9; z++)
                            {
                                if(i * j * x * y * h * z == model.MagicNumber)
                                {
                                    result.Add($"{i}{j}{x}{y}{h}{z}");
                                }
                            }
                        }
                    }
                }
            }
        }

        return result;
    }
}

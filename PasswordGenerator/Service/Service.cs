namespace PasswordGenerator;

public class Service
{
    public List<string> GeneratePass(Model model)
    {
        int n = model.N;
        int l = model.L;

        List<string> list = new List<string>();
        string result = "";

        for (int i = 1; i < n; i++) {

            for (int j = 1; j < n; j++)
            {
                for(int h = 97; h < 97 + l; h++)
                {
                    for (int k = 97; k < 97 + l; k++)
                    {
                        int high = i;

                        if(j > high)
                        {
                            high = j;
                        }

                        for(int x = high + 1; x <= n; x++)
                        {
                            result = $"{i}{j}{(char)h}{(char)k}{x}";
                            list.Add(result);
                            result = "";
                        }

                    }
                }
            }
        }
        return list;
    }
}

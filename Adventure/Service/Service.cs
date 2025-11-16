using System.Reflection;

namespace Adventure;

public class Service
{
    public string Result(Model model)
    {
        string destimation = "";
        string type = "";
        double usedBuget = 0;

        if(model.Buget <= 100)
        {
            destimation = "Bulgaria";

            if(model.Season == "summer")
            {
                type = "Camp";
                usedBuget = model.Buget * 30 / 100;
            }
            else if(model.Season == "winter")
            {
                type = "Hotel";
                usedBuget = model.Buget * 70 / 100;
            }
        }
        else if (model.Buget <= 1000)
        {
            destimation = "Balkans";

            if (model.Season == "summer")
            {
                type = "Camp";
                usedBuget = model.Buget * 40 / 100;
            }
            else if (model.Season == "winter")
            {
                type = "Hotel";
                usedBuget = model.Buget * 80 / 100;
            }
        }
        else
        {
            destimation = "Europe";
            type = "Hotel";
            usedBuget = model.Buget * 90 / 100;
        }

        return $"Somewhere in {destimation}\n{type} – {usedBuget:F2}";
    }
}

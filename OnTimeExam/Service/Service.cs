namespace OnTimeExam;

public class Service
{
    public string Calculate(Model model)
    {
        int startHour = model.HourExercise;
        int startMin = model.MinExercise;
        int arriveHour = model.AriveTimeHour;
        int arriveMin = model.AriveTimeMin;


        int diffMinStart = startHour * 60 + startMin;
        int diffMinArrive = arriveHour * 60 + arriveMin;

        int difference = diffMinArrive - diffMinStart;
        string result = "";

        int hour = Math.Abs(difference / 60);
        int min = Math.Abs(difference % 60);

        if (difference > 0)
        {
            result = "Late";
            if (hour == 0)
            {
                result += $"\n{min} minutes after the start";
            }
            else
            {
                result += $"\n{hour}:{min} hours after the start";
            }
        }

        else if (difference >= -30)
        {
            result = "On time!";
            if (difference < 0)
            {
                result += $"\n {min} minutes before the start";
            }
        }

        else
        {
            result = "Early";

            if (hour == 0)
            {

                result += $"\n{min} minutes before the start";
            }
            else
            {
                result += $"\n{hour}:{min} hours before the start";
            }
        }


        return result;
    }
}

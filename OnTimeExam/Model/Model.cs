namespace OnTimeExam;

public class Model
{
    public int HourExercise {  get; set; }
    public int MinExercise {  get; set; }
    public int AriveTimeHour {  get; set; }
    public int AriveTimeMin {  get; set; }

    public Model(int hourExercise, int minExercise, int ariveTimeHour, int ariveTimeMin)
    {
        HourExercise = hourExercise;
        MinExercise = minExercise;
        AriveTimeHour = ariveTimeHour;
        AriveTimeMin = ariveTimeMin;
    }
}

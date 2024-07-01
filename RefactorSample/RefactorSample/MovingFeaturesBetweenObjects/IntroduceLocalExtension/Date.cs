namespace RefactorSample.MovingFeaturesBetweenObjects.IntroduceLocalExtension;

public class Date
{
    public int Year { get; }
    public int Month { get; }
    public int Day { get; }

    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public string ToString() => $"{Year}-{Month:D2}-{Day:D2}";
}
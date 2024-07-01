namespace RefactorSample.MovingFeaturesBetweenObjects.IntroduceForeignMethod;

public class Before
{
    class Report 
    {
        // ...
        void SendReport()
        {
            var previousEnd = new DateTime();
            DateTime nextDay = previousEnd.AddDays(1);
            // ...
        }
    }
}
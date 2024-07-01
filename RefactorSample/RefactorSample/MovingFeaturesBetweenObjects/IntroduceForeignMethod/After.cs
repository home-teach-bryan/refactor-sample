namespace RefactorSample.MovingFeaturesBetweenObjects.IntroduceForeignMethod;

public class After
{
    class Report 
    {
        // ...
        void SendReport()
        {
            var previousEnd = new DateTime();
            DateTime nextDay = NextDay(previousEnd);
            // ...
        }
        private static DateTime NextDay(DateTime date) 
        {
            return date.AddDays(1);
        }
    }
}
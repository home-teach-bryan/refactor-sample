namespace RefactorSample.SimplifyingMethodCalls.PreserveWholeObject;

public class Before
{
    public void Sample()
    {
        var daysTempRange = new DaysTempRange();
        var plan = new Plan();
        
        int low = daysTempRange.GetLow();
        int high = daysTempRange.GetHigh();
        bool withinPlan = plan.WithinRange(low, high);
    }
}
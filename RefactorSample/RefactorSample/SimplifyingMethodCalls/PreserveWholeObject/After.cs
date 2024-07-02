namespace RefactorSample.SimplifyingMethodCalls.PreserveWholeObject;

public class After
{
    public void Sample()
    {
        var daysTempRange = new DaysTempRange();
        var plan = new Plan();
        bool withinPlan1 = plan.WithinRange(daysTempRange);
    }
}
namespace RefactorSample.SimplifyingMethodCalls.PreserveWholeObject;

public class Plan
{
    public bool WithinRange(int low, int high)
    {
        return true;
    }

    public bool WithinRange(DaysTempRange daysTempRange)
    {
        return false;
    }
}
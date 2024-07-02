namespace RefactorSample.SimplifyingMethodCalls.ReplaceExceptionWithTest;

public class Before
{
    private double[] values = new double[] { };

    double GetValueForPeriod(int periodNumber) 
    {
        try 
        {
            return values[periodNumber];
        } 
        catch (IndexOutOfRangeException e) 
        {
            return 0;
        }
    }
}
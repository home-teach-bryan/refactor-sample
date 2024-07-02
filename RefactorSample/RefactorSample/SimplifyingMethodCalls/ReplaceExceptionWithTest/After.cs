namespace RefactorSample.SimplifyingMethodCalls.ReplaceExceptionWithTest;

public class After
{
    private double[] values = new double[] { };

    double GetValueForPeriod(int periodNumber)
    {
        if (periodNumber >= values.Length)
        {
            return 0;
        }

        return values[periodNumber];
    }
}
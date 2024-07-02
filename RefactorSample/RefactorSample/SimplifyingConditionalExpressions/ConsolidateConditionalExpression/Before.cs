namespace RefactorSample.SimplifyingConditionalExpressions.ConsolidateConditionalExpression;

public class Before
{
    private int seniority = 1;
    private int monthsDisabled = 2;
    private bool isPartTime = true;

    double DisabilityAmount() 
    {
        if (seniority < 2) 
        {
            return 0;
        }
        if (monthsDisabled > 12) 
        {
            return 0;
        }
        if (isPartTime) 
        {
            return 0;
        }
        // Compute the disability amount.
        // ...
        return 1;
    }
}
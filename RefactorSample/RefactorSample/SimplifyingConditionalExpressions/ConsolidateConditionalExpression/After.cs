namespace RefactorSample.SimplifyingConditionalExpressions.ConsolidateConditionalExpression;

public class After
{
    private int seniority = 1;
    private int monthsDisabled = 2;
    private bool isPartTime = true;

    double DisabilityAmount()
    {
        if (IsNotEligibleForDisability())
        {
            return 0;
        }
        // Compute the disability amount.
        // ...
        return 1;
    }

    private bool IsNotEligibleForDisability()
    {
        if (seniority < 2 || monthsDisabled > 12 || isPartTime)
        {
           return true;
        }
        return false;
    }
}
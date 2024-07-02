namespace RefactorSample.SimplifyingConditionalExpressions.ReplaceNestedConditionalWithGuardClauses;

public class After
{
    private bool isDead = true;
    private bool isSeparated = true;
    private bool isRetired = true;

    public double GetPayAmount()
    {
        if (isDead)
        {
            return DeadAmount();
        }

        if (isSeparated)
        {
            return SeparatedAmount();
        }

        if (isRetired)
        {
            return RetiredAmount();
        }

        return NormalPayAmount();
    }
    private double NormalPayAmount()
    {
        return 10;
    }

    private double RetiredAmount()
    {
        return 50;
    }

    private double SeparatedAmount()
    {
        return 85;
    }

    private double DeadAmount()
    {
        return 95;
    }
}
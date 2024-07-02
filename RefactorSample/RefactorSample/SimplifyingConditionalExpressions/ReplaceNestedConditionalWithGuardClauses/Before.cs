namespace RefactorSample.SimplifyingConditionalExpressions.ReplaceNestedConditionalWithGuardClauses;

public class Before
{
    private bool isDead = true;
    private bool isSeparated = true;
    private bool isRetired = true;

    public double GetPayAmount()
    {
        double result;
        if (isDead)
        {
            result = DeadAmount();
        }
        else 
        {
            if (isSeparated)
            {
                result = SeparatedAmount();
            }
            else 
            {
                if (isRetired)
                {
                    result = RetiredAmount();
                }
                else
                {
                    result = NormalPayAmount();
                }
            }
        }
  
        return result;
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
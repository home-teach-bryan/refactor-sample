namespace RefactorSample.SimplifyingMethodCalls.ParameterizeMethod;

public class After
{
    public decimal Salary { get; private set; }

    public void GiveRaise(decimal percentage)
    {
        if (percentage < 0)
        {
            throw new ArgumentException("Raise percentage cannot be negative", nameof(percentage));
        }
        this.Salary *= (1 + percentage / 100);
    }
}
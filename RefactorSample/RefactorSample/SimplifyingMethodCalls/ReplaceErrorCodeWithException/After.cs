namespace RefactorSample.SimplifyingMethodCalls.ReplaceErrorCodeWithException;

public class After
{
    private int _balance;

    void Withdraw(int amount)
    {
        if (amount > _balance) 
        {
            throw new ArgumentException();
        }
        _balance -= amount;
    }
}
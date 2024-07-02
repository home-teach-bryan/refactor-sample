namespace RefactorSample.SimplifyingMethodCalls.ReplaceErrorCodeWithException;

public class Before
{
    private int _balance;

    int Withdraw(int amount) 
    {
        if (amount > _balance) 
        {
            return -1;
        }
        else 
        {
            _balance -= amount;
            return 0;
        }
    }
}
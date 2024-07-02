namespace RefactorSample.SimplifyingConditionalExpressions.ConsolidateDuplicateConditionalFragments;

public class Before
{
    public void Sample()
    {
        double total = 0;
        double price = 5;
        if (IsSpecialDeal()) 
        {
            total = price * 0.95;
            Send();
        }
        else 
        {
            total = price * 0.98;
            Send();
        }
    }

    private void Send()
    {
        // do something
    }

    private bool IsSpecialDeal()
    {
        return true;
    }
}
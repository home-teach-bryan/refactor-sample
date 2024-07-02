namespace RefactorSample.SimplifyingConditionalExpressions.DecomposeConditional;

public class After
{
    private readonly DateTime SUMMER_START = new DateTime(2024, 07, 01);
    private readonly DateTime SUMMER_END = new DateTime(2024, 09, 01);
    private int winterRate = 1;
    private int winterServiceCharge = 1;
    private int summerRate = 2;
    
    public int GetCharge(DateTime date, int quantity)
    {
        int charge = 0;
        if (IsSummer(date)) 
        {
            charge = SummerCharge(quantity);
        }
        else 
        {
            charge = WinterCharge(quantity);
        }

        return charge;
    }

    private int WinterCharge(int quantity)
    {
        return quantity * summerRate;
    }

    private int SummerCharge(int quantity)
    {
        return quantity * winterRate + winterServiceCharge;
    }

    private bool IsSummer(DateTime date)
    {
        return date < SUMMER_START || date > SUMMER_END;
    }
}
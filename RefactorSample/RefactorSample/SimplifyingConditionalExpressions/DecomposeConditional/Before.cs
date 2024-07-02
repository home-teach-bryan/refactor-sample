using RefactorSample.MovingFeaturesBetweenObjects.IntroduceLocalExtension;

namespace RefactorSample.SimplifyingConditionalExpressions.DecomposeConditional;

public class Before
{
    private readonly DateTime SUMMER_START = new DateTime(2024, 07, 01);
    private readonly DateTime SUMMER_END = new DateTime(2024, 09, 01);
    private int winterRate = 1;
    private int winterServiceCharge = 1;
    private int summerRate = 2;
    
    public int GetCharge(DateTime date, int quantity)
    {
        int charge = 0;
        if (date < SUMMER_START || date > SUMMER_END) 
        {
            charge = quantity * winterRate + winterServiceCharge;
        }
        else 
        {
            charge = quantity * summerRate;
        }

        return charge;
    }
}
namespace RefactorSample.SimplifyingConditionalExpressions.IntroduceNullObject;

public class BillingPlan : Plan
{
    public static BillingPlan Basic()
    {
        return new BillingPlan();
    }
}
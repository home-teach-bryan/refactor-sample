namespace RefactorSample.SimplifyingConditionalExpressions.IntroduceNullObject;

public class Before
{
    public void Sample(Customer customer) 
    {
        Plan plan;
        if (customer == null) 
        {
            plan = BillingPlan.Basic();
        }
        else
        {
            plan = customer.GetPlan();
        }
    }
}
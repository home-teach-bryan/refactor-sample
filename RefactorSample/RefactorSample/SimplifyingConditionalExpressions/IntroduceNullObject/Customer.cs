namespace RefactorSample.SimplifyingConditionalExpressions.IntroduceNullObject;

public abstract class Customer
{
    public abstract Plan GetPlan();

    public abstract bool IsNull { get; }
    
    
}
namespace RefactorSample.SimplifyingConditionalExpressions.IntroduceNullObject;

public class After
{
    public sealed class NullCustomer: Customer 
    {
        public override bool IsNull 
        {
            get { return true; }
        }
  
        public override Plan GetPlan() 
        {
            return new NullPlan();
        }
        // Some other NULL functionality.
    }
}
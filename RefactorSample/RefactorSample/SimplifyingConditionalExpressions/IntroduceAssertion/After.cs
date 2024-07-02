namespace RefactorSample.SimplifyingConditionalExpressions.IntroduceAssertion;

public class After
{
    private double expenseLimit;
    private double NULL_EXPENSE;
    
    double GetExpenseLimit(PrimaryProject primaryProject) 
    {
        //Assert.IsTrue(expenseLimit != NULL_EXPENSE || primaryProject != null);
        return (expenseLimit != NULL_EXPENSE) ?
            expenseLimit:
            primaryProject.GetMemberExpenseLimit();
    }
}
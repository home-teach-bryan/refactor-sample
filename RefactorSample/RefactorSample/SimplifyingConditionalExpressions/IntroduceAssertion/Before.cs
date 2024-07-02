namespace RefactorSample.SimplifyingConditionalExpressions.IntroduceAssertion;

public class Before
{
    private double expenseLimit;
    private double NULL_EXPENSE;
    
    double GetExpenseLimit(PrimaryProject primaryProject) 
    {
        // Should have either expense limit or
        // a primary project.
        return (expenseLimit != NULL_EXPENSE) ?
            expenseLimit :
            primaryProject.GetMemberExpenseLimit();
    } 
}


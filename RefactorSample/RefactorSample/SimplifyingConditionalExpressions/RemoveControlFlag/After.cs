namespace RefactorSample.SimplifyingConditionalExpressions.RemoveControlFlag;

public class After
{
    public bool Contains(List<string> people)
    {
        foreach (var person in people)
        {
            if (person == "Alice" || person == "Bob")
            {
                return true;
            }
        }

        return false;
    }
}
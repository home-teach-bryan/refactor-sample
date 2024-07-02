namespace RefactorSample.SimplifyingConditionalExpressions.RemoveControlFlag;

public class Before
{
    public bool Contains(List<string> people)
    {
        bool found = false;
        foreach (var person in people)
        {
            if (person == "Alice" || person == "Bob")
            {
                found = true;
                break;
            }
        }
        return found;
    }
}
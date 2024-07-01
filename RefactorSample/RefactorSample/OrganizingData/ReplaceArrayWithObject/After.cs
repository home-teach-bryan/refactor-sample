namespace RefactorSample.OrganizingData.ReplaceArrayWithObject;

public class After
{
    public void Print()
    {
        Performance row = new Performance();
        row.SetName("Liverpool");
        row.SetWins("15");
    }
}

public class Performance
{
    private string _liverpool;
    private string _wins;
    
    public void SetName(string liverpool)
    {
        this._liverpool = liverpool;
    }

    public void SetWins(string wins)
    {
        this._wins = wins;
    }
}
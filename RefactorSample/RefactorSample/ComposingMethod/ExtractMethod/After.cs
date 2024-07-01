namespace RefactorSample.ComposingMethod.ExtractMethod;

public class After
{
    private string _name;

    public After(string name)
    {
        _name = name;
    }
    
    public void PrintOwing()
    {
        this.PrintBanner();
        this.PrintDetail();
    }

    private void PrintDetail()
    {
        Console.WriteLine("name: " + this._name);
        Console.WriteLine("amount: " + this.GetOutstanding());
    }

    private string GetOutstanding()
    {
        return "GetOutstanding...";
    }

    private void PrintBanner()
    {
        Console.WriteLine("Printing Banner");
    }
}
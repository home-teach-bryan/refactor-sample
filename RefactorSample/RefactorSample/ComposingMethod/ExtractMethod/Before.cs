namespace RefactorSample.ComposingMethod.ExtractMethod;

public class Before
{
    private string _name;

    public Before(string name)
    {
        _name = name;
    }
    
    public void PrintOwing()
    {
        this.PrintBanner();
        // Print details.
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
namespace RefactorSample.ComposingMethod.SplitTemporaryVariable;

public class Before
{
    private double height;
    private double width;

    public Before(double height, double width)
    {
        this.height = height;
        this.width = width;
    }

    public void Print()
    {
        double temp = 2 * (height + width);
        Console.WriteLine(temp);
        temp = height * width;
        Console.WriteLine(temp);
    }
}
namespace RefactorSample.ComposingMethod.SplitTemporaryVariable;

public class After
{
    private double height;
    private double width;

    public After(double height, double width)
    {
        this.height = height;
        this.width = width;
    }

    public void Print()
    {
        double perimeter = 2 * (height + width);
        Console.WriteLine(perimeter);
        double area = height * width;
        Console.WriteLine(area);
    }
}
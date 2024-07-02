namespace RefactorSample.SimplifyingMethodCalls.ReplaceParameterWithMethodCall;

public class After
{
    private int quantity;
    private int itemPrice;

    public void Sample()
    {
        int basePrice = quantity * itemPrice;
        double finalPrice = DiscountedPrice(basePrice);
    }

    private double DiscountedPrice(int basePrice, double seasonDiscount, double fees)
    {
        return 0;
    }
    
    private double DiscountedPrice(int basePrice)
    {
        double seasonDiscount = this.GetSeasonalDiscount();
        double fees = this.GetFees();
        double finalPrice = seasonDiscount + fees;
        return finalPrice;
    }

    private double GetFees()
    {
        return 0;
    }

    private double GetSeasonalDiscount()
    {
        return 0;
    }
}
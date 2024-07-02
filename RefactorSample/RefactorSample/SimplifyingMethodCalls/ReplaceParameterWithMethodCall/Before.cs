using System.Net.Http.Headers;

namespace RefactorSample.SimplifyingMethodCalls.ReplaceParameterWithMethodCall;

public class Before
{
    private int quantity;
    private int itemPrice;

    public void Sample()
    {
        int basePrice = quantity * itemPrice;
        double seasonDiscount = this.GetSeasonalDiscount();
        double fees = this.GetFees();
        double finalPrice = DiscountedPrice(basePrice, seasonDiscount, fees);
    }

    private double DiscountedPrice(int basePrice, double seasonDiscount, double fees)
    {
        return 0;
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
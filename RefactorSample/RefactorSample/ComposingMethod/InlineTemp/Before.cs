namespace RefactorSample.ComposingMethod.InlineTemp;

public class Before
{
    bool HasDiscount(Order order)
    {
        double basePrice = order.BasePrice();
        return basePrice > 1000;
    }
}
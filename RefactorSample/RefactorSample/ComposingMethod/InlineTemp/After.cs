namespace RefactorSample.ComposingMethod.InlineTemp;

public class After
{
    bool HasDiscount(Order order)
    {
        return order.BasePrice() > 1000;
    }
}
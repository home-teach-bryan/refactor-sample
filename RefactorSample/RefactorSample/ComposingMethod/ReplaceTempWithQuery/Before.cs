namespace RefactorSample.ComposingMethod.ReplaceTempWithQuery;

public class Before
{
    private double _quantity;
    private double _itemPrice;

    public Before(double quantity, double itemPrice)
    {
        this._quantity = quantity;
        this._itemPrice = itemPrice;
    }

    double CalculateTotal() 
    {
        double basePrice = _quantity * _itemPrice;
  
        if (basePrice > 1000) 
        {
            return basePrice * 0.95;
        }
        else 
        {
            return basePrice * 0.98;
        }
    }
}
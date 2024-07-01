namespace RefactorSample.ComposingMethod.ReplaceTempWithQuery;

public class After
{
    private double _quantity;
    private double _itemPrice;

    public After(double quantity, double itemPrice)
    {
        this._quantity = quantity;
        this._itemPrice = itemPrice;
    }

    double CalculateTotal() 
    {
        
        if (BasePrice() > 1000) 
        {
            return BasePrice() * 0.95;
        }
        else 
        {
            return BasePrice() * 0.98;
        }
    }

    double BasePrice()
    {
        return _quantity * _itemPrice;
    }
}
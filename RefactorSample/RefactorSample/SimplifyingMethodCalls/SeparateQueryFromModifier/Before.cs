namespace RefactorSample.SimplifyingMethodCalls.SeparateQueryFromModifier;

public class Before
{
    public class Order
    {
        private List<OrderItem> items = new List<OrderItem>();

        public decimal GetTotalAndApplyDiscount(decimal discountRate)
        {
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.Price;
            }
        
            if (total > 1000)
            {
                total *= (1 - discountRate);
            }
        
            return total;
        }
    }

}
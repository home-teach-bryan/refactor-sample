namespace RefactorSample.SimplifyingMethodCalls.SeparateQueryFromModifier;

public class After
{
    public class Order
    {
        private List<OrderItem> items = new List<OrderItem>();

        public decimal GetTotal()
        {
            return items.Sum(item => item.Price);
        }

        public void ApplyDiscount(decimal discountRate)
        {
            if (GetTotal() > 1000)
            {
                foreach (var item in items)
                {
                    item.Price *= (1 - discountRate);
                }
            }
        }
    }
}
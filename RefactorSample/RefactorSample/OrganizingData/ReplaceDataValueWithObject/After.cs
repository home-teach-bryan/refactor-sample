namespace RefactorSample.OrganizingData.ReplaceDataValueWithObject;

public class After
{
    public class DiscountRate
    {
        private double rate;

        public DiscountRate(double rate)
        {
            if (rate < 0 || rate > 1)
            {
                throw new ArgumentException("Discount rate must be between 0 and 1");
            }
            this.rate = rate;
        }

        public double ApplyDiscount(double amount)
        {
            return amount * (1 - rate);
        }
    }

    public class Order
    {
        private string customerName;
        private DiscountRate discountRate;

        public Order(string customerName, double rate)
        {
            this.customerName = customerName;
            this.discountRate = new DiscountRate(rate);
        }

        public double CalculateTotal(double basePrice)
        {
            return discountRate.ApplyDiscount(basePrice);
        }
    }
}
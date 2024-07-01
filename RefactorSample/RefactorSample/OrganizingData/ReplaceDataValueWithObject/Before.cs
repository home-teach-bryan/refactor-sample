namespace RefactorSample.OrganizingData.ReplaceDataValueWithObject;

public class Before
{
    public class Order
    {
        private string customerName;
        private double discountRate;

        public Order(string customerName, double discountRate)
        {
            this.customerName = customerName;
            this.discountRate = discountRate;
        }

        public double CalculateTotal(double basePrice)
        {
            return basePrice * (1 - discountRate);
        }
    }
}
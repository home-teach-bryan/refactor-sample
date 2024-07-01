namespace RefactorSample.OrganizingData.ChangeValueToReference;

public class Before
{
    public class Customer
    {
        public string Name { get; }

        public Customer(string name)
        {
            Name = name;
        }
    }
    
    public class Order
    {
        public Customer Customer { get; }

        public Order(string customerName)
        {
            Customer = new Customer(customerName);
        }
    }
}
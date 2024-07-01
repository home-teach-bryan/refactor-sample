namespace RefactorSample.OrganizingData.ChangeUnidirectionalAssociationToBidirectional;

public class Before
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }

        public Order(int orderId, Customer customer)
        {
            OrderId = orderId;
            Customer = customer;
        }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public Customer(int customerId, string name)
        {
            CustomerId = customerId;
            Name = name;
        }
    }
}
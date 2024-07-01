namespace RefactorSample.OrganizingData.ChangeUnidirectionalAssociationToBidirectional;

public class After
{
    public class Order
    {
        public int OrderId { get; set; }
        private Customer _customer;

        public Customer Customer
        {
            get { return _customer; }
            set
            {
                if (_customer != null)
                    _customer.RemoveOrder(this);
                _customer = value;
                if (_customer != null)
                    _customer.AddOrder(this);
            }
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        private List<Order> _orders = new List<Order>();

        public IReadOnlyList<Order> Orders => _orders.AsReadOnly();

        public Customer(int customerId, string name)
        {
            CustomerId = customerId;
            Name = name;
        }

        public void AddOrder(Order order)
        {
            if (!_orders.Contains(order))
            {
                _orders.Add(order);
                order.Customer = this;
            }
        }

        public void RemoveOrder(Order order)
        {
            if (_orders.Remove(order))
                order.Customer = null;
        }
    }
}
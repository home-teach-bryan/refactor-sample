namespace RefactorSample.OrganizingData.ChangeReferenceToValue;

public class Before
{
    public class Customer
    {
        private Dictionary<string, Customer> _instance = new Dictionary<string, Customer>();
        
        public string Name { get; }

        public Customer(string name)
        {
            Name = name;
        }
        public Customer GetCustomer(string name)
        {
            if (!this._instance.ContainsKey(name))
            {
                this._instance[name] = new Customer(name);
            }
            return _instance[name];
        }
    }
    public class Order
    {
        public Customer Customer { get; }

        public Order(string customerName)
        {
            Customer = Customer.GetCustomer(customerName);
        }
    }
}
namespace RefactorSample.OrganizingData.ReplaceTypeCodeWithStateOrStrategy;

public class After
{
    public interface IPaymentStrategy
    {
        int Calculate();
    }

    public class EngineerPaymentStrategy : IPaymentStrategy
    {
        public int Calculate()
        {
            return 3000;
        }
    }

    public class SalesmanPaymentStrategy : IPaymentStrategy
    {
        public int Calculate()
        {
            return 2000 + (100 * 10); // 基本工資 + (銷售數量 * 佣金)
        }
    }

    public class ManagerPaymentStrategy : IPaymentStrategy
    {
        public int Calculate()
        {
            return 4000;
        }
    }

    public class Employee
    {
        private IPaymentStrategy _paymentStrategy;

        public Employee(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public int PayAmount()
        {
            return _paymentStrategy.Calculate();
        }
    }
}
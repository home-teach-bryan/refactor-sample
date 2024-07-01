namespace RefactorSample.OrganizingData.ReplaceTypeCodeWithStateOrStrategy;

public class Before
{
    public class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        private int _type;

        public Employee(int type)
        {
            _type = type;
        }

        public int PayAmount()
        {
            switch (_type)
            {
                case ENGINEER:
                    return CalculateEngineerPay();
                case SALESMAN:
                    return CalculateSalesmanPay();
                case MANAGER:
                    return CalculateManagerPay();
                default:
                    throw new ArgumentException("Invalid employee type");
            }
        }

        private int CalculateEngineerPay()
        {
            return 3000;
        }

        private int CalculateSalesmanPay()
        {
            return 2000 + (100 * 10); // 基本工資 + (銷售數量 * 佣金)
        }

        private int CalculateManagerPay()
        {
            return 4000;
        }
    }
}
namespace RefactorSample.OrganizingData.ReplaceTypeCodeWithClass;

public class Before
{
    public class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        private int _type;
        public string Name { get; set; }

        public Employee(int type, string name)
        {
            _type = type;
            Name = name;
        }

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int GetTypeCode() => _type;
        
        public decimal CalculateSalary()
        {
            switch (_type)
            {
                case ENGINEER:
                    return 5000;
                case SALESMAN:
                    return 4000 + 1000; // 基本工資 + 銷售佣金
                case MANAGER:
                    return 7000;
                default:
                    throw new ArgumentException("Invalid employee type");
            }
        }
    }
}
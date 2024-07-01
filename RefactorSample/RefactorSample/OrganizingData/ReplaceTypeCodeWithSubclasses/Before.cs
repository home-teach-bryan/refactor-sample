namespace RefactorSample.OrganizingData.ReplaceTypeCodeWithSubclasses;

public class Before
{
    public class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        private readonly int _type;
        public string Name { get; set; }

        public Employee(int type, string name)
        {
            _type = type;
            Name = name;
        }

        public virtual decimal CalculateSalary()
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

        public virtual string GetRole()
        {
            switch (_type)
            {
                case ENGINEER:
                    return "Engineer";
                case SALESMAN:
                    return "Salesman";
                case MANAGER:
                    return "Manager";
                default:
                    throw new ArgumentException("Invalid employee type");
            }
        }
    }
}
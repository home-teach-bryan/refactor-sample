namespace RefactorSample.OrganizingData.ReplaceTypeCodeWithClass;

public class After
{
    public abstract class EmployeeType
    {
        public abstract int TypeCode { get; }
        public abstract string TypeName { get; }
        public abstract decimal CalculateSalary();

        public static EmployeeType GetEmployeeType(int typeCode)
        {
            switch (typeCode)
            {
                case 0:
                    return new Engineer();
                case 1:
                    return new Salesman();
                case 2:
                    return new Manager();
                default:
                    throw new ArgumentException("Invalid employee type code");
            }
        }
    }

    public class Engineer : EmployeeType
    {
        public override int TypeCode => 0;
        public override string TypeName => "Engineer";
        public override decimal CalculateSalary() => 5000;
    }

    public class Salesman : EmployeeType
    {
        public override int TypeCode => 1;
        public override string TypeName => "Salesman";
        public override decimal CalculateSalary() => 4000 + 1000; // 基本工資 + 銷售佣金
    }

    public class Manager : EmployeeType
    {
        public override int TypeCode => 2;
        public override string TypeName => "Manager";
        public override decimal CalculateSalary() => 7000;
    }

    public class Employee
    {
        private EmployeeType _employeeType;
        public string Name { get; set; }

        public Employee(int typeCode, string name)
        {
            _employeeType = EmployeeType.GetEmployeeType(typeCode);
            Name = name;
        }

        public EmployeeType Type
        {
            get { return _employeeType; }
            set { _employeeType = value; }
        }

        public int GetTypeCode() => _employeeType.TypeCode;
        
        public decimal CalculateSalary() => _employeeType.CalculateSalary();
    }
}
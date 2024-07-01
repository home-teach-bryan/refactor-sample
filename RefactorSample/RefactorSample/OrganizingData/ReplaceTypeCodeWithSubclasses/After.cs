namespace RefactorSample.OrganizingData.ReplaceTypeCodeWithSubclasses;

public class After
{
    public abstract class Employee
    {
        public string Name { get; set; }

        protected Employee(string name)
        {
            Name = name;
        }

        public abstract decimal CalculateSalary();
        public abstract string GetRole();

        public static Employee Create(int type, string name)
        {
            switch (type)
            {
                case 0:
                    return new Engineer(name);
                case 1:
                    return new Salesman(name);
                case 2:
                    return new Manager(name);
                default:
                    throw new ArgumentException("Invalid employee type");
            }
        }
    }

    public class Engineer : Employee
    {
        public Engineer(string name) : base(name) { }

        public override decimal CalculateSalary() => 5000;
        public override string GetRole() => "Engineer";
    }

    public class Salesman : Employee
    {
        public Salesman(string name) : base(name) { }

        public override decimal CalculateSalary() => 4000 + 1000; // 基本工資 + 銷售佣金
        public override string GetRole() => "Salesman";
    }

    public class Manager : Employee
    {
        public Manager(string name) : base(name) { }

        public override decimal CalculateSalary() => 7000;
        public override string GetRole() => "Manager";
    }
}
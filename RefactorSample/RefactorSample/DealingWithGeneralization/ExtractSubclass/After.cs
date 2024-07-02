namespace RefactorSample.DealingWithGeneralization.ExtractSubclass;

public class After
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public int YearsOfService { get; set; }

        public virtual decimal CalculateSalary()
        {
            decimal salary = BaseSalary;
            if (YearsOfService > 5)
            {
                salary += 1000;
            }
            return salary;
        }
    }

    public class SalesEmployee : Employee
    {
        public decimal CommissionRate { get; set; }
        public decimal Sales { get; set; }

        public override decimal CalculateSalary()
        {
            decimal baseSalary = base.CalculateSalary();
            return baseSalary + (Sales * CommissionRate);
        }
    }
}
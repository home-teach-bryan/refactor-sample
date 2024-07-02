namespace RefactorSample.DealingWithGeneralization.ExtractSubclass;

public class Before
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public int YearsOfService { get; set; }
        public decimal CommissionRate { get; set; }
        public decimal Sales { get; set; }

        public decimal CalculateSalary()
        {
            decimal salary = BaseSalary;
            if (YearsOfService > 5)
            {
                salary += 1000;
            }
            if (CommissionRate > 0)
            {
                salary += Sales * CommissionRate;
            }
            return salary;
        }
    }
}
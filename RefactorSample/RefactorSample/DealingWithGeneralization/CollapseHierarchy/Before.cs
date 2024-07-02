namespace RefactorSample.DealingWithGeneralization.CollapseHierarchy;

public class Before
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public virtual decimal CalculateMonthlyPay()
        {
            return Salary / 12;
        }
    }

    public class Manager : Employee
    {
        public decimal Bonus { get; set; }

        public override decimal CalculateMonthlyPay()
        {
            return (Salary + Bonus) / 12;
        }
    }
}
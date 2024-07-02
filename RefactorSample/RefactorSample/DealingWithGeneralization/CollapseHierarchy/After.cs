namespace RefactorSample.DealingWithGeneralization.CollapseHierarchy;

public class After
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }  // Moved from Manager class

        public decimal CalculateMonthlyPay()
        {
            return (Salary + Bonus) / 12;  // Incorporates bonus calculation
        }
    }
}
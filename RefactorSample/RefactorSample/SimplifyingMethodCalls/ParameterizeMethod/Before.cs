namespace RefactorSample.SimplifyingMethodCalls.ParameterizeMethod;

public class Before
{
    public class Employee
    {
        public decimal Salary { get; private set; }

        public void GiveRaise()
        {
            this.Salary *= 1.1m; // 固定加薪10%
        }
    }
}
namespace RefactorSample.SimplifyingMethodCalls.ReplaceConstructorWithFactoryMethod;

public class After
{
    public class Employee
    {
        private readonly int _type;

        private Employee(int type)
        {
            _type = type;
        }
        
        public static Employee Create(int type)
        {
            var employee = new Employee(type); 
            // Do some heavy lifting.
            return employee;
        }
        // ...
    }
}
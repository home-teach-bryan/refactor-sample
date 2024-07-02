namespace RefactorSample.SimplifyingMethodCalls.ReplaceConstructorWithFactoryMethod;

public class Before
{
    public class Employee 
    {
        private readonly int type;

        public Employee(int type) 
        {
            this.type = type;
        }
        // ...
    }
}
namespace RefactorSample.MovingFeaturesBetweenObjects.RemoveMiddleMan;

public class Before
{
    public void Print()
    {
        var person = new Person();
        var department = person.GetManager();
    }
    
    public class Person
    {
        private Department _department = new Department(new Person());

        public Person GetManager()
        {
            return this._department.Manager;
        }
    }

    public class Department
    {
        public Person Manager { get; }

        public Department(Person manager)
        {
            this.Manager = manager;
        }
    }
}
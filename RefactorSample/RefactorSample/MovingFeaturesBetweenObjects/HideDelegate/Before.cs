namespace RefactorSample.MovingFeaturesBetweenObjects.HideDelegate;

public class Before
{
    public void Print()
    {
        var person = new Person();
        var department = person.GetDepartment();
    }
    
    public class Person
    {
        public Department GetDepartment()
        {
            return new Department();
        }
    }

    public class Department
    {
        public Person GetManager()
        {
            return new Person();
        }
    }
}
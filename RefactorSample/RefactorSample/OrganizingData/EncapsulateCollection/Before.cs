namespace RefactorSample.OrganizingData.EncapsulateCollection;

public class Before
{
    public class Course
    {
        public string Name { get; set; }

        public Course(string name)
        {
            Name = name;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public Student(string name)
        {
            Name = name;
            Courses = new List<Course>();
        }
    }
}
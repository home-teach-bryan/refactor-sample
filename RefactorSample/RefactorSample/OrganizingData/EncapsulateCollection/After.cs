namespace RefactorSample.OrganizingData.EncapsulateCollection;

public class After
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
        private List<Course> _courses = new List<Course>();

        public Student(string name)
        {
            Name = name;
        }

        public IReadOnlyList<Course> Courses => _courses.AsReadOnly();

        public void AddCourse(Course course)
        {
            if (!_courses.Contains(course))
            {
                _courses.Add(course);
            }
        }

        public void RemoveCourse(Course course)
        {
            _courses.Remove(course);
        }

        public Course GetCourse(string name)
        {
            return _courses.FirstOrDefault(c => c.Name == name);
        }

        public int CourseCount => _courses.Count;
    }
}
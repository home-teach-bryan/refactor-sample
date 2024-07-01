namespace RefactorSample.MovingFeaturesBetweenObjects.InlineClass;

public class After
{
    public class Person
    {
        private string _name;
        private string _officeAreaCode;
        private string _officeNumber;

        public Person(string name, string officeAreaCode, string officeNumber)
        {
            _name = name;
            _officeAreaCode = officeAreaCode;
            _officeNumber = officeNumber;
        }

        public string GetTelephoneNumber()
        {
            return this._officeNumber;
        }
    }
}
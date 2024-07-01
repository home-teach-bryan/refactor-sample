namespace RefactorSample.MovingFeaturesBetweenObjects.ExtractClass;

public class After
{
    public class Person
    {
        private string _name;
        private string _officeAreaCode;

        public Person(string name, string officeAreaCode)
        {
            _name = name;
            _officeAreaCode = officeAreaCode;
        }
    }

    public class TelephoneNumber
    {
        private string _officeNumber;
        
        public string GetTelephoneNumber()
        {
            return this._officeNumber;
        }
    }
}
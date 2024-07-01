namespace RefactorSample.OrganizingData.ReplaceSubclassWithFields;

public class After
{
    public class Bird
    {
        private string _name;
        private double _speed;

        public Bird(string name, double speed)
        {
            _name = name;
            _speed = speed;
        }

        public string GetName() => _name;
        public double GetSpeed() => _speed;
    }
}
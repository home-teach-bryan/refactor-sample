namespace RefactorSample.DealingWithGeneralization.PullUpConstructorBody;

public class Before
{
    public class Manager: Employee 
    {
        private readonly string _name;
        private readonly string _id;
        private readonly int _grade;

        public Manager(string name, string id, int grade) 
        {
            this._name = name;
            this._id = id;
            this._grade = grade;
        }
        // ...
    }
}
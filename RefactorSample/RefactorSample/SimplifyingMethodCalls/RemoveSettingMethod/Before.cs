namespace RefactorSample.SimplifyingMethodCalls.RemoveSettingMethod;

public class Before
{
    public class Employee
    {
        private string name;
        private int id;

        public Employee(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int newId)
        {
            id = newId;
        }
    }
}
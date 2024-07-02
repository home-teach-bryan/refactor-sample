namespace RefactorSample.SimplifyingMethodCalls.RemoveSettingMethod;

public class After
{
    public class Employee
    {
        public string Name { get; }
        public int Id { get; }

        public Employee(string name, int id)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("姓名不能為空", nameof(name));
            if (id <= 0)
                throw new ArgumentException("ID必須為正數", nameof(id));

            Name = name;
            Id = id;
        }
    }
}
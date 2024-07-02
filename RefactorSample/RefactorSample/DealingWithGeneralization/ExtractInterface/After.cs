namespace RefactorSample.DealingWithGeneralization.ExtractInterface;

public class After
{
    public interface IAnimal
    {
        string Name { get; set; }
        void Eat();
    }
    
    public class Dog : IAnimal
    {
        public string Name { get; set; }
    
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    
        public void Eat()
        {
            Console.WriteLine("Eating dog food");
        }
    }
}
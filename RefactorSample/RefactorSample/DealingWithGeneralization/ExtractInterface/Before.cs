namespace RefactorSample.DealingWithGeneralization.ExtractInterface;

public class Before
{
    public class Dog
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
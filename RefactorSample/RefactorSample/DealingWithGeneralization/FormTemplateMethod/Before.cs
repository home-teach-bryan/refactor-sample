namespace RefactorSample.DealingWithGeneralization.FormTemplateMethod;

public class Before
{
    public class Coffee
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public void AddSugarAndMilk()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }

    public class Tea
    {
        public void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public void AddLemon()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
namespace RefactorSample.DealingWithGeneralization.ExtractSuperclass;

public class Before
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelEfficiency { get; set; }

        public void StartEngine()
        {
            Console.WriteLine($"Starting {Make} {Model}'s engine.");
        }

        public double CalculateFuelConsumption(double distance)
        {
            return distance / FuelEfficiency;
        }
    }

    public class Motorcycle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelEfficiency { get; set; }

        public void StartEngine()
        {
            Console.WriteLine($"Kickstarting {Make} {Model}'s engine.");
        }

        public double CalculateFuelConsumption(double distance)
        {
            return distance / FuelEfficiency;
        }
    }
}
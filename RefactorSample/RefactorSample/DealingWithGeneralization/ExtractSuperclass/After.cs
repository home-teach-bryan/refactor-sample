namespace RefactorSample.DealingWithGeneralization.ExtractSuperclass;

public class After
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelEfficiency { get; set; }

        public abstract void StartEngine();

        public double CalculateFuelConsumption(double distance)
        {
            return distance / FuelEfficiency;
        }
    }

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine($"Starting {Make} {Model}'s engine.");
        }
    }

    public class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine($"Kickstarting {Make} {Model}'s engine.");
        }
    }
}
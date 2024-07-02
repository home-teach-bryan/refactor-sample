namespace RefactorSample.SimplifyingConditionalExpressions.ReplaceConditionalWithPolymorphism;

public class After
{
    public abstract class Bird 
    {
        private string type;
        private double numberOfCoconuts = 0;
        private bool isNailed = true;
        private decimal voltage = 0;
        private const string EUROPEAN = "EUROPEAN";
        private const string AFRICAN = "AFRICAN";
        private const string NORWEGIAN_BLUE = "NORWEGIAN_BLUE";

        // ...
        public abstract double GetSpeed();

        protected double GetLoadFactor()
        {
            return 0;
        }

        protected  double GetBaseSpeed(decimal voltage = 0)
        {
            return 0;
        }
    }

    public class European : Bird
    {
        public override double GetSpeed()
        {
            return GetBaseSpeed();
        }
    }

    public class African : Bird
    {
        private readonly int _numberOfCoconuts;
        
        public override double GetSpeed() 
        {
            return GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts;
        }
    }
}
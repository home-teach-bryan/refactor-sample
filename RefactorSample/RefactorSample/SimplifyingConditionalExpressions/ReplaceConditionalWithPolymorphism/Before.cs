namespace RefactorSample.SimplifyingConditionalExpressions.ReplaceConditionalWithPolymorphism;

public class Before
{
    public class Bird 
    {
        private string type;
        private double numberOfCoconuts = 0;
        private bool isNailed = true;
        private decimal voltage = 0;
        private const string EUROPEAN = "EUROPEAN";
        private const string AFRICAN = "AFRICAN";
        private const string NORWEGIAN_BLUE = "NORWEGIAN_BLUE";

        // ...
        public double GetSpeed() 
        {
            switch (type) 
            {
                case EUROPEAN:
                    return GetBaseSpeed();
                case AFRICAN:
                    return GetBaseSpeed() - GetLoadFactor() * numberOfCoconuts;
                case NORWEGIAN_BLUE:
                    return isNailed ? 0 : GetBaseSpeed(voltage);
                default:
                    throw new Exception("Should be unreachable");
            }
        }

        private double GetLoadFactor()
        {
            return 0;
        }

        private double GetBaseSpeed(decimal voltage = 0)
        {
            return 0;
        }
    }
}
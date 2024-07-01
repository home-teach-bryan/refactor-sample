namespace RefactorSample.OrganizingData.ReplaceSubclassWithFields;

public class Before
{
    public abstract class Bird
    {
        public abstract string GetName();
        public abstract double GetSpeed();
    }

    public class European : Bird
    {
        public override string GetName() => "European";
        public override double GetSpeed() => 35;
    }

    public class African : Bird
    {
        public override string GetName() => "African";
        public override double GetSpeed() => 40;
    }

    public class NorwegianBlue : Bird
    {
        public override string GetName() => "Norwegian Blue";
        public override double GetSpeed() => 45;
    }
}
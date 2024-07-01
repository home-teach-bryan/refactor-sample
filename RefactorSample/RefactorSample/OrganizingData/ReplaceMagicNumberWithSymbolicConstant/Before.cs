namespace RefactorSample.OrganizingData.ReplaceMagicNumberWithSymbolicConstant;

public class Before
{
    double PotentialEnergy(double mass, double height) 
    {
        return mass * height * 9.81;
    }
}
namespace RefactorSample.ComposingMethod.InlineMethod;

public class Before
{
    public class PizzaDelivery
    {
        private int numberOfLateDeliveries;

        public PizzaDelivery(int numberOfLateDeliveries)
        {
            this.numberOfLateDeliveries = numberOfLateDeliveries;
        }

        int GetRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }
        bool MoreThanFiveLateDeliveries() 
        {
            return numberOfLateDeliveries > 5;
        }
    }
}
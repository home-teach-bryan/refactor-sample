namespace RefactorSample.ComposingMethod.InlineMethod;

public class After
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
            return numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}
namespace FP.Patterns.Strategy.Exercice3
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay()
        {
            Console.WriteLine("You have paid with Credit Card");
        }
    }
}

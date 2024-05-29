namespace FP.Patterns.Strategy.Exercice3
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay()
        {
            Console.WriteLine("You have paid with PayPal");
        }
    }
}

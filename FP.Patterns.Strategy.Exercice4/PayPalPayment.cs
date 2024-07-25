namespace FP.Patterns.Strategy.Exercice4
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay()
        {
            Console.WriteLine($"The payment is completed by PayPal");
        }
    }
}

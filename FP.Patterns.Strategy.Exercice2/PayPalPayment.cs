namespace FP.Patterns.Strategy.Exercice2
{
    public class PayPalPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"You are paying {amount} with Paypal");
        }
    }
}

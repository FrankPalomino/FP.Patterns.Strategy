namespace FP.Patterns.Strategy.Exercice3
{
    public class CryptoPayment : IPaymentStrategy
    {
        public void Pay()
        {
            Console.WriteLine("You have paid with Crypto currency");
        }
    }
}

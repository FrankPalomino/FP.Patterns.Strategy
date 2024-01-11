namespace FP.Patterns.Strategy.Exercice2
{
    public class CryptoPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"You are paying {amount} in Crypto");
        }
    }
}

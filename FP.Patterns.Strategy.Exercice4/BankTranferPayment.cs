namespace FP.Patterns.Strategy.Exercice4
{
    public class BankTranferPayment : IPaymentStrategy
    {
        public void Pay()
        {
            Console.WriteLine($"The payment is completed by Bank Tranfer");
        }
    }
}

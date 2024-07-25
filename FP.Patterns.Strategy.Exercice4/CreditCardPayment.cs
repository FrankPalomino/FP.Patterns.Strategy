namespace FP.Patterns.Strategy.Exercice4
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay()
        {
            Console.WriteLine($"The payment is completed by Credit Card");
        }
    }
}

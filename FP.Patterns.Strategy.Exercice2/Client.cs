namespace FP.Patterns.Strategy.Exercice2
{
    public class Client
    {
        private IPayment _paymentMethod;

        public void SetPaymentMethod(IPayment payment)
        {
            _paymentMethod = payment;
        }

        public void Pay(decimal amount)
        {
            _paymentMethod.Pay(amount);
        }
    }
}

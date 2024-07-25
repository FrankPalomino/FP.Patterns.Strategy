namespace FP.Patterns.Strategy.Exercice4
{
    public class PaymentContext
    {
        private IPaymentStrategy _strategy;

        public PaymentContext(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Pay()
        {
            _strategy.Pay();
        }
    }
}

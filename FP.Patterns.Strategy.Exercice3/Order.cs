namespace FP.Patterns.Strategy.Exercice3
{
    public class Order
    {
        private IPaymentStrategy _strategy;
        public Order(IPaymentStrategy strategy)
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

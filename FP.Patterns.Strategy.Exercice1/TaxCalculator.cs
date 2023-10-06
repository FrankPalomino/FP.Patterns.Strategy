namespace FP.Patterns.Strategy.Exercice1
{
    internal class TaxCalculator
    {
        private ITax _tax;

        public TaxCalculator(ITax tax)
        {
            _tax = tax;
        }

        public decimal CalculateTax(decimal gains)
        {
            return _tax.CalculateTax(gains);
        }
    }
}

namespace FP.Patterns.Strategy.Exercice1
{
    public class VatTax : ITax
    {
        public decimal CalculateTax(decimal gains)
        {
            return gains * 0.3m;
        }
    }
}

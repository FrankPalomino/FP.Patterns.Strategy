namespace FP.Patterns.Strategy.Exercice1
{
    public class CapitalGainsTax : ITax
    {
        public decimal CalculateTax(decimal gains)
        {
            return gains * 0.1m;
        }
    }
}

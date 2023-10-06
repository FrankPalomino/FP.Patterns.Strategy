namespace FP.Patterns.Strategy.Exercice1
{
    public class IncomeTax : ITax
    {
        public decimal CalculateTax(decimal gains)
        {
            return gains * 0.2m;
        }
    }
}

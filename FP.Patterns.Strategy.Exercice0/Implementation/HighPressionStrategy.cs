namespace FP.Patterns.Strategy.Implementation
{
    public class HighPressionStrategy : IGameStrategy
    {
        public void Play()
        {
            System.Console.WriteLine("High pression strategy");
        }
    }
}

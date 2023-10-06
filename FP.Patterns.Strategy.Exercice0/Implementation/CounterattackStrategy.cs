namespace FP.Patterns.Strategy.Implementation
{
    public class CounterattackStrategy : IGameStrategy
    {
        public void Play()
        {
            System.Console.WriteLine("Counterattack strategy");
        }
    }
}

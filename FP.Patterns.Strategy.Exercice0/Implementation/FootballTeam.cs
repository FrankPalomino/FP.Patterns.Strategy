namespace FP.Patterns.Strategy.Implementation
{
    public class FootballTeam
    {
        public int PlayersNumber { get; set; }
        public string HeadCoach { get; set; }

        private IGameStrategy _strategy;

        public void SetStrategy(IGameStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ShowStrategy()
        {
            _strategy.Play();
        }
    }
}

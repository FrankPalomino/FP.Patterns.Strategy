using FP.Patterns.Strategy.Implementation;

FootballTeam argentine = new FootballTeam();
argentine.SetStrategy(new BallPosetionStrategy());
argentine.ShowStrategy();
Console.WriteLine("--------------------");

FootballTeam brazil = new FootballTeam();
brazil.SetStrategy(new BallPosetionStrategy());
brazil.ShowStrategy();
Console.WriteLine("--------------------");

FootballTeam marocco = new FootballTeam();
marocco.SetStrategy(new CounterattackStrategy());
marocco.ShowStrategy();
Console.WriteLine("--------------------");
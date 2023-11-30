namespace Lab2;

class Program
{
    public static void Main(string[] args)
    {
        var players = new List<Account>
        {
            new Account("Liza"),
            new Account("Artem"),
            new StreakAccount("Nikita"),
            new StreakAccount("Kirill"),
            new PremiumAccount("Denis"),
            new PremiumAccount("Max")
        };

        var rand = new Random();

        for (int i = 0; i < 3; i++)
        {
            var player = players[rand.Next(players.Count)];
            var opponent = players.Where(x => x != player).ToList()[rand.Next(players.Count - 1)];

            Game.Play(GameType.Classic, player, opponent, 3);
            Game.Play(GameType.Training, player, opponent);
            Game.Play(GameType.Random, player, opponent);
        }

        Console.WriteLine("All games history:");
        Stats.Write(Stats.All());

        var randomPlayer = players[rand.Next(players.Count)];
        Console.WriteLine($"Game History for {randomPlayer.Username}:");
        Stats.Write(Stats.AccountStats(randomPlayer));
    }
}
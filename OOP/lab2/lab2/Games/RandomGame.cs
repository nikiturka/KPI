namespace Lab2;

public class RandomGame : Game
{
    private static readonly Random random = new Random();
    private readonly int randomScore;

    public RandomGame(Account player, Account opponent) : base(player, opponent)
    {
        randomScore = random.Next(1, 11);
        Score = randomScore;
    }
}
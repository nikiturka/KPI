namespace Lab2;

public class TrainingGame : Game
{
    public TrainingGame(Account player, Account opponent) : base(player, opponent)
    {
        Score = 0;
    }
}
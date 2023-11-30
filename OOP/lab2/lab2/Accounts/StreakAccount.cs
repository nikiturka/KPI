namespace Lab2;

public class StreakAccount : Account
{
    public int Bonus => Streak >= 3 ? Streak : 0;
    private int Streak { get; set; } = 0;

    public StreakAccount(string username) : base(username) {
        Type = AccountType.Streak;
    }

    protected override void WinGame(Game game)
    {
        Streak++;
        Rating += Bonus;
        base.WinGame(game);
    }

    protected override void LoseGame(Game game)
    {
        Streak = 0;
        base.LoseGame(game);
    }
}
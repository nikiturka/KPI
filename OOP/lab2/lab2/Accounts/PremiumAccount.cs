namespace Lab2;

public class PremiumAccount : Account
{
    public PremiumAccount(string username) : base(username){
        Type = AccountType.Premium;
    }

    protected override void WinGame(Game game)
    {
        Rating += (game.Score * 2);
    }
}
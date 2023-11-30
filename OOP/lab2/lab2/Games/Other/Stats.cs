namespace Lab2;

public static class Stats
{
    private static List<Game> History;

    static Stats()
    {
        History = new List<Game>();
    }

    public static void Add(Game game)
    {
        if (History.Any(x => x.GameId == game.GameId))
            return;
        History.Add(game);
    }

    public static List<Game> All()
    {
        return History.ToList();
    }

    public static List<Game> AccountStats(Account person)
    {
        return History.Where(x => x.Winner == person || x.Loser == person).ToList();
    }

    public static int PreviousRating(Account person, Game game)
    {
        var list = AccountStats(person);
        var id = list.IndexOf(game);

        if (id == 0) return Account.InitRating;

        var prevGame = list[id - 1];

        return person == prevGame.Winner ? prevGame.WinnerRating : prevGame.LoserRating;
    }

    public static void Write(List<Game> list)
    {
        Console.WriteLine(
              "*----------------------------------------------------------------------------------------------------*\n"
            + "| ID  |  GameType  | Score | Winner   <->     Type |   Rating   | Loser    <->     Type |   Rating   |\n"
            + "*----------------------------------------------------------------------------------------------------*"
        );
        foreach (var game in list)
        {
            Console.WriteLine(
                $"| {game.GameId,-3} | {game.Type,-10} | {game.Score,-5} " +
                $"| {game.Winner.Username,-10} {game.Winner.Type,10} " +
                $"| {Stats.PreviousRating(game.Winner, game),-3} -> {game.WinnerRating,3} " +
                $"| {game.Loser.Username,-10} {game.Loser.Type,10} " +
                $"| {Stats.PreviousRating(game.Loser, game),-3} -> {game.LoserRating,3} |");
        }

        Console.WriteLine(
            "*----------------------------------------------------------------------------------------------------*"
        );
    }
}
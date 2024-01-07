using Lab4.DB.Service;

namespace Lab4
{
    internal class GameAccount
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int CurrentRating { get; set; }
        public int GamesCount { get; set; }
        public List<GameResult> GameResults { get; set; } = new List<GameResult>();
        public GameAccountService Service { get; set; }

        public GameAccount(GameAccountService service, int ID, string userName, int gamesCount = 0)
        {
            Service = service;
            UserName = userName;
            CurrentRating = 100;
            GamesCount = gamesCount;
            Id = ID;
        }
        public void WinGame(Game game, string player, int gameIndex)
        {
            int rating = RatingCalc(game.getPlayRating(this));
            CurrentRating += rating;
            GamesCount++;
            string winner = "виграв";
            GameResults.Add(new GameResult(player, winner, rating, gameIndex, CurrentRating));
            Service.Update(this);
        }
        public void LoseGame(Game game, string player, int gameIndex)
        {
            int rating = RatingCalc(game.getPlayRating(this));
            if (CurrentRating > 1)
            {
                CurrentRating -= rating;
                if (CurrentRating < 1)
                {
                    CurrentRating = 1;
                }
            }
            GamesCount++;
            string winner = "програв";
            GameResults.Add(new GameResult(player, winner, rating, gameIndex, CurrentRating));
            Service.Update(this);
        }
        public void DrawGame(Game game, string player, int gameIndex, int currentRating)
        {
            GamesCount++;
            int rating = RatingCalc(game.getPlayRating(this));
            string winner = "нічия";
            GameResults.Add(new GameResult(player, winner, rating, gameIndex, currentRating));
            Service.Update(this);
        }

        public virtual int RatingCalc(int rating)
        {
            return rating;
        }
    }
}

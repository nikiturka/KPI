using Lab4.DB.Service;

namespace Lab4.Commands
{
    internal class ShowGamesForPlayerCommand : ICommand
    {
        private readonly GameAccountService _gameAccountService;
        public ShowGamesForPlayerCommand(GameAccountService gameAccountService)
        {
            _gameAccountService = gameAccountService;
        }

        public void Execute()
        {
            Console.WriteLine("Введіть ID гравця, ігри якого хочете побачити:");
            int playerID = int.Parse(Console.ReadLine());
            GameAccount player = _gameAccountService.ReadById(playerID);
            Console.WriteLine($"Інформація про гравця {player.UserName}:");
            List<GameResult> games = _gameAccountService.GameResults(player);
            foreach (GameResult game in games)
            {
                Console.WriteLine($"Гра проти  {game.Opponent} ,  {game.IsWin} , Рейтинг на який грали:  {game.Rating} , Ваш рейтинг:  {game.CurrentRating} , Гра #{game.GameIndex}");
            }
        }
    }
}

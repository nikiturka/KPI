using Lab4.DB.Service;

namespace Lab4.Commands
{
    internal class ShowAllPlayersCommand : ICommand
    {
        private readonly GameAccountService _gameAccountService;
        public ShowAllPlayersCommand(GameAccountService gameAccountService)
        {
            _gameAccountService = gameAccountService;
        }

        public void Execute()
        {
            List<GameAccount> playersList = _gameAccountService.ReadAll();
            foreach (GameAccount player in playersList)
            {
                Console.WriteLine($"ID гравця: {player.Id}, Ім'я: {player.UserName}, Поточний рейтинг: {player.CurrentRating}");
            }
        }
    }
}

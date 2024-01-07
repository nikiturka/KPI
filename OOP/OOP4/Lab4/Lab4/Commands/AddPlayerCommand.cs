using Lab4.DB.Service;
using Lab4.Account;

namespace Lab4.Commands
{
    internal class AddPlayerCommand : ICommand
    {
        private readonly GameAccountService _gameAccountService;
        public AddPlayerCommand(GameAccountService gameAccountService)
        {
            _gameAccountService = gameAccountService;
        }
        public void Execute()
        {
            Console.WriteLine("Введіть ім'я нового гравця: ");
            string name = Console.ReadLine();
            GameAccount player = AccountChose(_gameAccountService, name);
            _gameAccountService.Create(player);
        }

        private GameAccount AccountChose(GameAccountService service, string userName)
        {
            Console.WriteLine("Оберіть тип акаунту: \n1.StandartAccount \n2.StableRatingAccount \n3.PowerAccount");
            int choose = int.Parse(Console.ReadLine());
            var Id = service.ReadAll().Count();
            switch (choose)
            {
                case 1:
                    var standartGameAccount = new StandartAccount(service, Id, userName);
                    return standartGameAccount;
                case 2:
                    var stableRatingAccount = new StableRatingAccount(service, Id, userName);
                    return stableRatingAccount;
                case 3:
                    var powerAccount = new PowerAccount(service, Id, userName);
                    return powerAccount;
                default:
                    Console.WriteLine("Невірно. Оберіть з 1-3");
                    return AccountChose(service, userName);
            }
        }
    }
}

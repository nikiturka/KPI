using Lab3.DB;
using Lab3.DB.Service;
using Lab3.GameAccountTypes;

namespace Lab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var context = new DbContext();
            var accountService = new GameAccountService(context);
            var gameService = new GameService(context);
            Program program = new Program();
            program.Run(accountService, gameService);
        }
        public void Run(GameAccountService accountService, GameService gameService)
        {
            Console.WriteLine("Введіть ім'я 1 гравця: ");
            string firstPlayer = Console.ReadLine();
            GameAccount player1 = AccountChose(accountService, firstPlayer);
            Console.WriteLine("Введіть ім'я 2 гравця: ");
            string secondPlayer = Console.ReadLine();
            GameAccount player2 = AccountChose(accountService, secondPlayer);
            int i;
            Game game = GameType(player1, player2, gameService);
            game.PlayGame(player1, player2);
            for (i = 0; i < 2; i++)
            {
                game.PlayGame(player1, player2);
            }
            GetStats(accountService);
        }

        public void GetStats(GameAccountService accountService)
        {
            var listAccounts = accountService.ReadAll();
            foreach (var account in listAccounts)
            {
                account.GetStats();
            }
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
                    service.Create(standartGameAccount);
                    return standartGameAccount;
                case 2:
                    var stableRatingAccount = new StableRatingAccount(service, Id, userName);
                    service.Create(stableRatingAccount);
                    return stableRatingAccount;
                case 3:
                    var powerAccount = new PowerAccount(service, Id, userName);
                    service.Create(powerAccount);
                    return powerAccount;
                default:
                    Console.WriteLine("Невірно. Оберіть з 1-3");
                    return AccountChose(service, userName);
            }
        }

        private Game GameType(GameAccount player1, GameAccount player2, GameService service)
        {
            Console.WriteLine("Оберіть тип гри: \n1.StandartGame \n2.UnrankedGame \n3.Point5Game");
            int choose = int.Parse(Console.ReadLine());
            GameFactory factory = new GameFactory();
            switch (choose)
            {
                case 1:
                    return factory.CreateStandartGame(player1, player2, service);
                case 2:
                    return factory.CreateUnrankedGame(player1, player2, service);
                case 3:
                    return factory.CreatePoint5Game(player1, player2, service);
                default:
                    Console.WriteLine("Невірно. Оберіть 1,2 або 3.");
                    return GameType(player1, player2, service);
            }
        }
    }
}
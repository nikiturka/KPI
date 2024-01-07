using Lab4.DB.Service;
using Lab4.GameType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class GameFactory
    {
        public Game CreateStandartGame(GameAccount player1, GameAccount player2, GameService service)
        {
            return new StandartGame(player1, player2, service);
        }
        public Game CreateUnrankedGame(GameAccount player1, GameAccount player2, GameService service)
        {
            return new UnrankedGame(player1, player2, service);
        }
        public Game CreatePoint5Game(GameAccount player1, GameAccount player2, GameService service)
        {
            return new Point5Game(player1, player2, service);
        }
    }
}

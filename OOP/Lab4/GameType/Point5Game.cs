using Lab4.DB.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.GameType
{
    class Point5Game : Game
    {
        public Point5Game(GameAccount player1, GameAccount player2, GameService service) : base(player1, player2, service) { }
        public override int getPlayRating(GameAccount player)
        {
            if (player.UserName == player1.UserName)
            { return playRating + 5; }
            if (player.UserName == player2.UserName)
            { return playRating + 5; }
            return 0;
        }
    }
}

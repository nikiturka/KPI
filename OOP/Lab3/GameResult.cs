using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class GameResult
    {
        public string Opponent { get; set; }
        public string IsWin { get; set; }
        public int Rating { get; set; }
        public int GameIndex { get; set; }
        public int CurrentRating { get; set; }

        public GameResult(string opponent, string isWin, int rating, int gameIndex, int currentRating)
        {
            Opponent = opponent;
            IsWin = isWin;
            Rating = rating;
            GameIndex = gameIndex;
            CurrentRating = currentRating;
        }
        public GameResult() { }
    }
}

using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel;
using System.Numerics;
namespace Lab2;

public class GameFactory
{
    public Game CreateGame(GameType Type, Account player, Account opponent, uint score = 5)
    {
    //    Game g   = Type switch
    //    {
    //        GameType.Classic => new ClassicGame(player, opponent, score),
    //        GameType.Training => new TrainingGame(player, opponent),
    //        GameType.Random=> new RandomGame(player, opponent)
    //};
    //    return g;    
            
            
            switch(Type)
        {
            case GameType.Classic: return new ClassicGame(player, opponent, score); break;
            case GameType.Training: return new TrainingGame(player, opponent); break;
            case GameType.Random: return new RandomGame(player, opponent); break;
        };
        return null;
    }

}
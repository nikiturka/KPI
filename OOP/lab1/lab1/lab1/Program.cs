namespace Lab1;

public class Program
{
    public static void Main(string[] args)
    {
        var Nikita = new GameAccount("Nikita");
        var Max = new GameAccount("Max");
        var Denis = new GameAccount("Denis");

        Nikita.WinGame(Denis, 5);

        Nikita.GetStats();
        Console.WriteLine("\n");

        Nikita.GetHistory();
        Console.WriteLine("\n");

        Denis.GetStats();
        Console.WriteLine("\n");

        for (int i = 1; i <= 3; i++)
        {
            Max.WinGame(Nikita, (uint)i);
        }

        Game.GetHistory();
        Console.WriteLine("\n");

        Max.GetStats();
        Console.WriteLine("\n");

        Nikita.GetStats();

        Denis.WinGame(Nikita, 10);

        Denis.GetStats();
        Console.WriteLine("\n");

        Nikita.GetStats();
        Console.WriteLine("\n");
    }
}
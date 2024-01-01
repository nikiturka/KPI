using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Utility
    {
        public static int GetValidInput(string text, int minLimit, int maxLimit)
        {
            bool valid = false;
            string input;
            int choice = 0;

            while (!valid )
            {
                Console.Write($"Enter {text}: ");
                input =  Console.ReadLine();
                valid = GetInput(input, out choice, minLimit, maxLimit);
                if (!valid)
                    Console.WriteLine("Invalid input. Try again.");
            }

            return choice;
        }
        public static bool GetInput(string stringToConvert, out int intOutValue, int minLimit, int maxLimit)
        {
            bool parsed = int.TryParse(stringToConvert, out intOutValue);
            return parsed && intOutValue >= minLimit && intOutValue <= maxLimit;
        }
        public static string CheckPassword()
        {
            string password = "";
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        return null;
                    case ConsoleKey.Enter:
                        return password;
                    case ConsoleKey.Backspace:
                        if (password.Length > 0)
                        {
                            password = password.Substring(0, (password.Length - 1));
                            Console.Write("\b \b");
                        }
                        break;
                    default:
                        password += key.KeyChar;
                        Console.Write("*");
                        break;
                }
            }
        }
        public static void PrintProductTable(List<Product> productList)
        {
            var output = new StringBuilder();
            output.AppendLine("\n");
            foreach (var item in productList)
                output.AppendLine(item.toRow());
            Console.Write(output);
        }

        public static void PrintBasketTable(List<BasketItem> basketList)
        {
            var output = new StringBuilder();
            foreach (var item in basketList)
                output.AppendLine(item.toRow());
            Console.Write(output);
        }
        
        public static void PrintHistoryTable(List<HistoryItem> historyList)
        {
            var output = new StringBuilder();
            foreach (var item in historyList)
            {
                output.AppendLine(item.toRow());
            }
            Console.Write(output);
        }
        public static void PrintHistory(List<History> history)
        {
            foreach (var purchase in history)
            {
                Console.WriteLine($"History ID: {purchase.HistoryID}.\nDate: {purchase.Date}");
                PrintHistoryTable(purchase.HistoryItems);
            }
        }
    }
}

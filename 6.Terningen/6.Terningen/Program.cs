using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Terningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this creates a random number and add the random number have to be between 0 - 7
            Random random = new Random();
            int dice = random.Next(1, 7);


            // the whole if statement
            if (dice == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Du slog en " + dice);
            }
            else if (dice == 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du slog en " + dice);
            }
            else if (dice == 3)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Du slog en " + dice);
            }
            else if (dice == 4)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Du slog en " + dice);
            }
            else if (dice == 5)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du slog en " + dice);
            }
            else if (dice == 6)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Du slog en " + dice);
            }
        }
    }
}

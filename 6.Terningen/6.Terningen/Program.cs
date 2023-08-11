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

            // this is to change the color of console and the text itself
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;


            // this creates a random number and add the random number have to be between 0 - 7
            Random random = new Random();
            int dice = random.Next(1, 7);


            // the whole if statement
            if (dice == 1)
            {
                Console.WriteLine("Du slog en " + dice);
            }
            else if (dice == 2)
            {
                Console.WriteLine("Du slog en " + dice);
            }
            else if (dice == 3)
            {
                Console.WriteLine("Du slog en " + dice);
            }
            else if (dice == 4)
            {
                Console.WriteLine("Du slog en " + dice);
            }
            else if (dice == 5)
            {
                Console.WriteLine("Du slog en " + dice);
            }
            else if (dice == 6)
            {
                Console.WriteLine("Du slog en " + dice);
            }
        }
    }
}

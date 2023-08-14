using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.juletræet_med_sin_pynt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a number");

            byte number = byte.Parse(Console.ReadLine());

            for (byte i = 0; i <= number; i++)
            {
                // Print leading spaces
                for (byte j = 1; j <= number - i; j++)
                {
                    Console.Write(" ");
                }

                // Counter to keep track of the star's position
                int starCounter = 1;

                // Print stars
                for (byte k = 0; k < 2 * i - 1; k++)
                {
                    if (starCounter % 2 == 0)// Set color to red for even-numbered stars
                    {
                        Console.ForegroundColor = ConsoleColor.Red; 
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    Console.Write("*");
                    starCounter++;
                }

                Console.ResetColor(); // Reset color after printing the row
                Console.WriteLine();
            }
        }
    }
}

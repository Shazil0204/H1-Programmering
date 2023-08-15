using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.stars_and_stripes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i  = 0; i < 12; i++)
            {
                if (i == 0 || i == 10)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("                       ");

                    if (i == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("               ");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" *   *   *   *   *   * ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("               ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("               ");
                    }
                }
                else if (i >= 1 && i <= 9) 
                {

                    if (i == 1 || i == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("   *   *   *   *   *   ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("               ");
                    }
                    else if (i == 2 || i == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" *   *   *   *   *   * ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("               ");
                    }
                    else if (i == 3 || i == 7 )
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("   *   *   *   *   *   ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("               ");
                    }
                    else if (i == 4 || i == 8 )
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" *   *   *   *   *   * ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("               ");
                    }
                }
            }
            
            for( int i = 1; i < 16; i++ )
            {
                if (i == 1 || i == 4 || i == 5 || i == 8 || i == 9 || i == 12 || i == 13)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("                                      ");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("                                      ");
                }
            }
            Console.ReadKey();

        }
    }
}

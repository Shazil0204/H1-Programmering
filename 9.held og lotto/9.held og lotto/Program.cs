using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace _9.held_og_lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] lottoNumber = new int[8];

            for (int i = 0; i < 8; i++)
            {
                lottoNumber[i] = random.Next(1, 37);
            }

            int a = 0;

            foreach (int i in lottoNumber)
            {
                if (7 == a)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    a++;
                }

                Console.Write(i + "\t");

                Thread.Sleep(2000);

                Console.ResetColor();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

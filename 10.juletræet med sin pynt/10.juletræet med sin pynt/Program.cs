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

            int number = int.Parse(Console.ReadLine());

            string star = "";

            for (int i = 0; i <= number; i++)
            {
                for (int j = 1; j <= number - i; j++)
                {
                    star += " ";
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    star += "*";
                }
                star += "\n";
            }

            Console.WriteLine(star);
        }
    }
}

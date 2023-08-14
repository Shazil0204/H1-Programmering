using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retake_of_American_flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "";

            int abcd = 0;

            string[] ResultArray = new string[5];

            int[] eachline = new int[] { 15, 23, 38 };

            for (int i = 0; i < eachline.Length; i++)
            {
                for (int j = 0; j < eachline[i]; j++)
                {
                    char a = ' ';

                    result = result + a.ToString();
                }

                ResultArray[i] = result;

                //Console.WriteLine(result); 
                Console.WriteLine(abcd);
                abcd++;
            }

            foreach (string s in ResultArray)
            {
                Console.WriteLine(s);
            }

            // overe here i have the rest of the flag i mean the bottom part of the flag

            int k = 1;

            bool changeColor = false;

            for (int i = 0; i < 15; i++)
            {
                if (changeColor == true)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }

                k++;

                if (k % 2 == 0)
                {
                    changeColor = !changeColor;
                    k = 0;
                }

                Console.WriteLine(ResultArray[2]);
            }
            Console.ResetColor();
        }
    }
}

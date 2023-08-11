using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Morsekoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type something: ");

            string UserInput = (Console.ReadLine());

            char[] UserInputInChar = UserInput.ToCharArray();

            foreach (char c in UserInputInChar)
            {
                switch(c)
                {
                    case 'a':
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Variable_og_datatyper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task a

            int length = 16;

            double width = 5.1;

            Console.WriteLine(length + width);



            // Task b

            int area = width * length;

            // The reason Visual Studio compiler won't translate my code is because area can't hold a double value.



            // Task c

            double d = width * length;

            // The reason Visual Studio compiler wants to translate my code is because d is a double now and it can hold the value of double.

        }
    }
}

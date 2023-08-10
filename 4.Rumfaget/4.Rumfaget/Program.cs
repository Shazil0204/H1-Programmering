using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Rumfaget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type the lenght of the object: ");

            float length = float.Parse(Console.ReadLine());

            Console.Write("Please type the height of the object: ");

            float height = float.Parse(Console.ReadLine());

            Console.Write("Please type the width  of the object: ");

            float width = float.Parse(Console.ReadLine());

            float result = length * height * width;

            Console.WriteLine("The Volume of the object is " + result);
        }
    }
}

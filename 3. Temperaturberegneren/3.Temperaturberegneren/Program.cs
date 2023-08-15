using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Temperaturberegneren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please tell me the temperature over there: ");

            float celcius = float.Parse(Console.ReadLine());

            float fahrenheit = (celcius * 1.8f) + 32;

            float reamur = celcius * 0.8f;

            Console.WriteLine("" +
                "The  temperature you type is " + celcius + " °C\n" +
                "This temperature in fahrenheit is " + fahrenheit + " °F\n" +
                "This temperature in reamur is " + reamur + " °Ré");

        }
    }
}

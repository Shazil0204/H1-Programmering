using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.BMI_udregneren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please tell me your height in meter: ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("Please tell me your weight in Kg: ");
            ushort weight = ushort.Parse(Console.ReadLine());

            float BMI = (weight / (height * height));
            Console.WriteLine(String.Format("Your BMI is around {0:0.0} ", BMI));

            float[] BMInumbers = new float[5];

            BMInumbers[0] = 18.5f;
            BMInumbers[1] = 24F;
            BMInumbers[2] = 30f;
            BMInumbers[3] = 35F;
            BMInumbers[4] = 40F;

            if (BMI <= BMInumbers[0])
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("BMI Status:\t");
                Console.WriteLine("Body weight deficit");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (BMI <= BMInumbers[1])
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("BMI Status:\t");
                Console.WriteLine("normal");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (BMI <= BMInumbers[2])
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("BMI Status:\t");
                Console.WriteLine("weight over");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (BMI <= BMInumbers[3])
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("BMI Status:\t");
                Console.WriteLine("obesity first degree");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (BMI <= BMInumbers[4])
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("BMI Status:\t");
                Console.WriteLine("obesity second degree");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (BMI > BMInumbers[4])
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("BMI Status:\t");
                Console.WriteLine("obesity third degree");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}

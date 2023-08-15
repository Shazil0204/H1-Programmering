using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _12.Vinos_blancos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller();
        }
        static void Controller()
        {
            View();
            Model();
            Console.ReadLine();
        }
        static void View()
        {
            Console.WriteLine("Over here i have a graph from the information given by the database");
        }
        static int[] Model()
        {

            // This is my database
            int[] Sale_of_Vine = {
                 175134 , 
                 175388 , 
                 172818 , 
                 142709 , 
                 151437 , 
                 152620 , 
                 150979 , 
                 152210 , 
                 149450 , 
                 154398 , 
                 150160 };

            Sale_of_Vine[5] = Sale_of_Vine[5] + 35432;

            Array.Sort(Sale_of_Vine);

            int max = Sale_of_Vine.Max();

            const byte maxStar = 100;
            
            for (int i = 0; i < Sale_of_Vine.Length; i++)
            {
                int star = maxStar * Sale_of_Vine[i] / max;

                Dots_Controller(star);
            }

            return Sale_of_Vine;
        }
        static void Dots_Controller(int Dots)
        {
            for (int i = 0; i < Dots; i++)
            {
                View_Dots();
         
            }
            Console.WriteLine("");
        }

        static void View_Dots()
        {
            Console.Write("*");
        }
    }
}

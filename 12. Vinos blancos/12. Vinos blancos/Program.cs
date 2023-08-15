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
            Console.WriteLine(Model()[1, 1]);
            Console.ReadLine();
        }

        static void View()
        {
            //Console.WriteLine("Over here i have a graph from the information given by the database");

            Console.WriteLine("Go and read on you own");
        }

        static int[,] Model()
        {
            int[,] Sale_of_Vine = {  // THIS HAS TO BE ASINGLE ARRAY
                { 2009, 175134 }, 
                { 2010, 175388 }, 
                { 2011, 172818 }, 
                { 2012, 142709 }, 
                { 2013, 151437 }, 
                { 2014, 152620 }, 
                { 2015, 150979 }, 
                { 2016, 152210 }, 
                { 2017, 149450 }, 
                { 2018, 154398 }, 
                { 2019, 150160 }  };

            Array.Sort(Sale_of_Vine);

            return Sale_of_Vine;
        }
    }
}

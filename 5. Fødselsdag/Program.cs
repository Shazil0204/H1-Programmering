using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fødselsdag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            Console.WriteLine("Date of birth:");

            Console.WriteLine("\r\nMonth (m)");
            int months = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\r\nDay (dd)");
            int days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\r\nYear (yyyy)");
            int years = Convert.ToInt32(Console.ReadLine());

            DateTime birthday = new DateTime(years, months, days);

            TimeSpan age = today - birthday;

            Console.WriteLine("\r\nYou're " + age.Days / 365 + " years old");
            Console.WriteLine("You're " + age.Days + " days old");
            Console.WriteLine("You're " + age.Days * 24 + " hours old");
            Console.WriteLine("You're " + age.Days * 1440 + " minutes old");
            Console.WriteLine("You're " + age.Days * 86400 + " seconds old");

            Console.ReadLine();
        }
    }
}

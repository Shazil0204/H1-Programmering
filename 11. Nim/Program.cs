using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte pool = 7;

            Console.WriteLine("Imagin there are " + pool + "matchsticks");

            bool turn = false; // this will be use to understand hows turn it is

            while (pool > 0)
            {
                turn = !turn; // because of this it will always bi computer that will go first

                if (turn == true) // this code is for computer
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("It is computers turn.");

                    byte ComputerNumber = 0;
                    if (pool >= 3)
                    {
                        Random rnd = new Random();

                        ComputerNumber = Convert.ToByte(rnd.Next(1, 4));

                        pool = Convert.ToByte(pool - ComputerNumber);

                        Console.WriteLine("Computer have chosen number: " + ComputerNumber + "\n\nThere are " + pool + " Matchsticks left behind on the table\n");
                    }
                    else 
                    {
                        Random rnd = new Random();
                        
                        ComputerNumber = Convert.ToByte(rnd.Next(1, pool));

                        pool = Convert.ToByte(pool - ComputerNumber);

                        Console.WriteLine("Computer have chosen number: " + ComputerNumber + "\n\nThere are " + pool + " Matchsticks left behind on the table\n");
                    }

                    Console.ResetColor();
                }
                else if (turn == false) // this code is for users
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("It is User's turn.");

                    if (pool >= 3)
                    {
                        Console.WriteLine("Please type a number between 1 & 3");
                        
                        byte UserNumber = Convert.ToByte(Console.ReadLine());
                        
                        if (UserNumber > 3)
                        {
                            Console.WriteLine("Invalid number!");
                            turn = !turn; // because of this we will give the turn to computer but because when the code will go back to while loop it will be changed again and then user turn will come back
                        }
                        else
                        {
                            pool = Convert.ToByte(pool - UserNumber);

                            Console.WriteLine("yOU have chosen number: " + UserNumber + "\n\nThere are " + pool + " Matchsticks left behind on the table\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Please type a number between 1 & " + pool);

                        byte UserNumber = Convert.ToByte(Console.ReadLine());

                        if (UserNumber > pool)
                        {
                            Console.WriteLine("Invalid number!");
                            turn = !turn; // because of this we will give the turn to computer but because when the code will go back to while loop it will be changed again and then user turn will come back
                        }
                        else
                        {
                            pool = Convert.ToByte(pool - UserNumber);

                            Console.WriteLine("you have chosen number: " + UserNumber + "\n\nThere are " + pool + " Matchsticks left behind on the table\n");
                        }

                    }
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor= ConsoleColor.Red;
            if(turn == false)
            {
                Console.WriteLine("You have picked the last matchstick that is why you have lost the game :(");
            }
            else
            {
                Console.WriteLine("Computer have picked the last matchstick that is why you have won the game :)");
            }
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}

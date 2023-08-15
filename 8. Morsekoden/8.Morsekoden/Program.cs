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
                        Console.WriteLine(" · — ");
                        break;
                    case 'b':
                        Console.WriteLine(" — · · · ");
                        break;
                    case 'c':
                        Console.WriteLine(" — · — · ");
                        break;
                    case 'd':
                        Console.WriteLine(" — · · ");
                        break;
                    case 'e':
                        Console.WriteLine(" · ");
                        break;
                    case 'f':
                        Console.WriteLine(" · · — · ");
                        break;
                    case 'g':
                        Console.WriteLine(" — — · ");
                        break;
                    case 'h':
                        Console.WriteLine(" · · · · ");
                        break;
                    case 'i':
                        Console.WriteLine(" · · ");
                        break;
                    case 'j':
                        Console.WriteLine(" · — — — ");
                        break;
                    case 'k':
                        Console.WriteLine(" — · — ");
                        break;
                    case 'l':
                        Console.WriteLine(" · — · · ");
                        break;
                    case 'm':
                        Console.WriteLine(" — — ");
                        break;
                    case 'n':
                        Console.WriteLine(" — · ");
                        break;
                    case 'o':
                        Console.WriteLine(" — — — ");
                        break;
                    case 'p':
                        Console.WriteLine(" · — — · ");
                        break;
                    case 'q':
                        Console.WriteLine(" — — · — ");
                        break;
                    case 'r':
                        Console.WriteLine(" · — · ");
                        break;
                    case 's':
                        Console.WriteLine(" · · · ");
                        break;
                    case 't':
                        Console.WriteLine(" — ");
                        break;
                    case 'u':
                        Console.WriteLine(" · · — ");
                        break;
                    case 'v':
                        Console.WriteLine(" · · · — ");
                        break;
                    case 'w':
                        Console.WriteLine(" · — — ");
                        break;
                    case 'x':
                        Console.WriteLine(" — · · — ");
                        break;
                    case 'y':
                        Console.WriteLine(" — · — — ");
                        break;
                    case 'z':
                        Console.WriteLine(" — — · · ");
                        break;
                    case 'æ':
                        Console.WriteLine(" · — · — ");
                        break;
                    case 'ø':
                        Console.WriteLine(" — — — · ");
                        break;
                    case 'å':
                        Console.WriteLine(" · — — · — ");
                        break;
                    case '1':
                        Console.WriteLine(" · — — — — ");
                        break;
                    case '2':
                        Console.WriteLine(" · · — — — ");
                        break;
                    case '3':
                        Console.WriteLine(" · · · — — ");
                        break;
                    case '4':
                        Console.WriteLine(" · · · · — ");
                        break;
                    case '5':
                        Console.WriteLine(" · · · · · ");
                        break;
                    case '6':
                        Console.WriteLine(" — · · · · ");
                        break;
                    case '7':
                        Console.WriteLine(" — — · · · ");
                        break;
                    case '8':
                        Console.WriteLine(" — — — · · ");
                        break;
                    case '9':
                        Console.WriteLine(" — — — — · ");
                        break;
                    case '0':
                        Console.WriteLine(" — — — — — ");
                        break;
                    case '.':
                        Console.WriteLine(" · — · — · — ");
                        break;
                    case ',':
                        Console.WriteLine(" — — · · — — ");
                        break;
                    case ':':
                        Console.WriteLine(" — — — · · · ");
                        break;
                    case '?':
                        Console.WriteLine(" · · — — · · ");
                        break;
                    case '\'':
                        Console.WriteLine(" · — — — — · ");
                        break;
                    case '-':
                        Console.WriteLine(" — · · · · — ");
                        break;
                    case '/':
                        Console.WriteLine(" — · · — · ");
                        break;
                    case '(':
                        Console.WriteLine(" — · — — · ");
                        break;
                    case ')':
                        Console.WriteLine(" — · — — · — ");
                        break;
                    case '"':
                        Console.WriteLine(" · — · · — · ");
                        break;
                    //case ' ':
                    //    Console.WriteLine(" · — · — ");
                    //    break;
                    case '@':
                        Console.WriteLine(" · — — · — · ");
                        break;

                    default:
                        break;

                }
            }
        }
    }
}

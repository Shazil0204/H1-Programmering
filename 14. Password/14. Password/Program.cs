using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainController();
        }

        #region View

        /// <summary>
        /// This Method will tell user all the information in the program. Like what user have to do and what will happens if user does this
        /// </summary>
        static void FirstInformation()
        {
            Console.WriteLine("\nHello and welcome create a valid password\n");
            Console.WriteLine("You have to create a valid password and these are the following thing that will make sure you have a valid password:\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1.\tMake sure your password is longer then 12 characters and smaller then 64 characters\n");
            Console.WriteLine("2.\tMake sure your password contains both upper and lower case characters\n");
            Console.WriteLine("3.\tMake sure your password is a mix of numbers and characters\n");
            Console.WriteLine("4.\tMake sure your password has atleast one special characters\n");
            Console.WriteLine("5.\tMake sure your password does not have the following this\n");
            Console.WriteLine("-> Make sure your password does not have 4 letters or numbers of the same type come right after each other, such as BBBB or 3333\n");
            Console.WriteLine("-> Make sure your password does not have the number sequence 1234 or 3456 is consecutive and of a minimum of 4 consecutive characters\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("If you follow all 5 rules then your password is consider Green\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("If you only follow first 4 rules then your password is consider Yellow\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("If you don't follow any of the first 4 rules your password will be consider Red\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Green: "); Console.ResetColor(); Console.WriteLine("Password is powerful enough to be okay\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Yellow: "); Console.ResetColor(); Console.WriteLine("Password is Ok but we will prefer you to make it Green\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Red: "); Console.ResetColor(); Console.WriteLine("Password is not powerful enough\n");
            Console.Write("Please write your password here:\t");
        }

        /// <summary>
        /// This is just to show if the password follows all the requirments
        /// </summary>
        static void GreenPassword()
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("\nPassword is powerful enough to be okay\n");
            Console.ResetColor();
        }

        /// <summary>
        /// This is just to show if the password follows only the necessary requirments
        /// </summary>
        static void YellowPassword()
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("\nPassword is Ok but we will prefer you to make it Green\n");
            Console.WriteLine("Your Password does follows the first 4 requirments but is not following the 5 rule.");
            Console.ResetColor();
        }

        /// <summary>
        /// This method is to ask user about creating a new password
        /// </summary>
        static void YellowPasswordGUI()
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.Write("\nDo you want to create a new password? Y - Yes / N - No:\t");
            Console.ResetColor();
        }

        /// <summary>
        /// This is just to show if the password does not follow the necessary requirments
        /// </summary>
        static void RedPassword()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("\nPassword is not powerful enough\n");
            Console.WriteLine("Your Password does not follow the first 4 requirments");
            Console.ResetColor();
        }

        #endregion
        
        #region Controller
        
        /// <summary>
        /// This controller will controll the whole program it have all the method in it
        /// </summary>
        static void MainController()
        {
            NecessaryPasswordRequirment();
        }

        /// <summary>
        /// This method will make sure that password follows the necessary Requirments like the first 4 rules
        /// </summary>
        static void NecessaryPasswordRequirment()
        {
            bool recreate = true;

            while (recreate)
            {
                FirstInformation();
                string UserPassword = Console.ReadLine();

                if (UserPassword.Length >= 12 && UserPassword.Length <= 64)
                {
                    if (UserPassword.Any(char.IsUpper) && UserPassword.Any(char.IsLower))
                    {

                        if (UserPassword.Any(p => !char.IsLetterOrDigit(p) == true)) // can't use => this so i have to find a for loop
                        {
                            bool containsSpecialChar = false;
                            foreach (char p in UserPassword)
                            {
                                if (char.IsLetterOrDigit(p))
                                {
                                    containsSpecialChar = true;
                                    break;
                                }
                            }

                            if (containsSpecialChar == true)
                            {
                                if (UserPassword.Any(char.IsDigit))
                                {
                                    SameLetterOrCharacters(UserPassword);
                                    recreate = false;
                                }
                                else { RedPassword(); }
                            }
                            else { RedPassword(); }
                        }
                        else { RedPassword(); }
                    }
                    else { RedPassword(); }
                }
                else { RedPassword(); }
            }
        }

        /// <summary>
        /// This method will only work if the NecessaryPasswordRequirment method is completed properly. this method will make sure that password does not have more then 3 same letters or characters
        /// </summary>
        static void SameLetterOrCharacters(string UP)
        {
            int check = 1;
            bool sendresult = false;

            for (int i = 0; i < UP.Length - 1; i++)
            {
                if (UP[i] == UP[i + 1])
                {
                    check++;
                }
                else
                {
                    check = 1;
                }

                if (check == 4)
                {
                    sendresult = true;
                    break;
                }
            }

            if (sendresult == false)
            {
                LettersInRow(UP);
            }
            else
            {
                YellowPassword();
                YellowPasswordReply();
            }
        }

        /// <summary>
        /// This method make sure that your password does not have 4 same characters next to each other
        /// </summary>
        static void LettersInRow(string UP)
        {
            int check = 1;
            bool sendresult = false;

            for (int i = 0; i < UP.Length - 1; i++)
            {
                if (UP[i] + 1 == UP[i + 1])
                {
                    check++;
                }
                else
                {
                    check = 1;
                }

                if (check == 4)
                {
                    sendresult = true;
                    break;
                }
            }

            if (sendresult == false)
            {
                Finalization(sendresult);
            }
            else 
            {
                YellowPassword();
                YellowPasswordReply();
            }
        }

        /// <summary>
        /// This method will ask user if the user want to make a new password because user's password is not really strong
        /// </summary>
        static void YellowPasswordReply()
        {
            YellowPasswordGUI();
            
            string reply = (Console.ReadLine());

            reply = reply.ToUpper();

            if (reply == "Y")
            {
                Console.Clear();
                NecessaryPasswordRequirment();
            }
        }

        /// <summary>
        /// This method will only work if all the other method are done and will just tell user that its password is Green
        /// </summary>
        /// <param name="finalResult"></param>
        static void Finalization(bool finalResult)
        {
            GreenPassword();
        }

        #endregion
    }
}

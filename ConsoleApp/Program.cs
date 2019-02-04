using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start the console with asking 'Your name'
            var Name = new Name();
            Console.WriteLine("What is your name?");
            Name.UserName = Console.ReadLine();
            Console.WriteLine("----------------------------");

            int userInput = 0;


            // Loop while user doesn't input '4' (exit)
            do
            {
                switch (userInput)
                {
                    case 0:
                        userInput = DisplayMenu();
                        break;
                    case 1:
                        try
                        {
                            Console.WriteLine("What is your name?");
                            Name.UserName = Console.ReadLine();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\a Something went wrong!"); //Giving friendly error with windows alert sound
                        }

                        userInput = 0;
                        break;
                    case 2:
                        try
                        {
                            var calculator = new Calculator();
                            calculator.Calculate();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\a Something went wrong!"); //Giving friendly error with windows alert sound
                        }

                        userInput = 0;
                        break;
                    case 3:
                        Console.WriteLine("Your name is set as: {0}", Name.UserName);
                        userInput = 0;
                        break;
                    case 4:
                        // Shows current date and time
                        Console.WriteLine(DateTime.Now);

                        userInput = 0;
                        break;
                    case 5:
                        // if userInput = 5 simply exist the console
                        Environment.Exit(0);
                        break;
                    default:
                        userInput = 0;
                        break;
                }
                Console.WriteLine("----------------------------");
            }
            while (userInput != 5);

            // Exit console application
            Environment.Exit(0);
        }

        /// <summary>
        ///   The main menu displaying method
        /// </summary>
        /// <returns> int result </returns>
        static public int DisplayMenu()
        {
            Console.WriteLine("Console Application");
            Console.WriteLine();
            Console.WriteLine("1. Set new name");
            Console.WriteLine("2. Calculator");
            Console.WriteLine("3. Show your name");
            Console.WriteLine("4. Show date and time");
            Console.WriteLine("5. Exit");
            var answer = Console.ReadLine();

            // try parse string to int
            bool success = Int32.TryParse(answer, out int result);

            // if successfully parsed, return selected item as int
            if (success)
                return result;

            // else show menu again
            return 0;
        }
    }
}

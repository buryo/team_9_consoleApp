using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GuessGame
    {
        public void Game()
        {
            Console.WriteLine("Player 1 what is your name?");
            string player1 = Console.ReadLine();

            Console.WriteLine("Player 2 what is your name?");
            string player2 = Console.ReadLine();

            Console.WriteLine(player1 + " vs " + player2);

            Console.WriteLine("Let the game begin! Press any key to continue");

            Console.WriteLine("Guess the number! hint: between 0 and 1000");
            Console.WriteLine(player1 + " :");



            Random random = new Random();
            int winNumber = random.Next(1, 1000);

            bool win = false;

            do
            {
                Console.Write("Guess the number " + player1 + " :");
                string answer = Console.ReadLine();

                int i = int.Parse(answer);
                if (i > winNumber)
                {
                    Console.WriteLine("You guessed to high! guess again");
                }
                else if (i < winNumber)
                {
                    Console.WriteLine("You guessed to low! guess again");
                }
                else if (i == winNumber)
                {
                    Console.WriteLine("Congratulations! You won!");
                }

            } while (win == false);
        }
    }
       
    
   class Program
    { 
        static int index = 0;
        static void Main(string[] args)
        {
            var game = new GuessGame();
            //introWordLib.bereken(2.0, 3.9);
            //variables for entry IntroWordLib before menu is visible.
            string flower, color, name, food, nameUser;

            Console.WriteLine("Hello, What is your name? ");
            nameUser = Console.ReadLine(); 
       
            Console.WriteLine( "Hello " + nameUser + " enter a name of a flower in plural form: ");
            flower = Console.ReadLine();

            Console.WriteLine("And now enter a color which is not blue: ");
            color = Console.ReadLine();

            Console.WriteLine("And now enter a name of a person: ");
            name = Console.ReadLine();

            Console.WriteLine("And now enter a name of food: ");
            food = Console.ReadLine();

            //console gets cleared from the lines above and only lines here under is shown. 
            Console.Clear();

            Console.WriteLine(flower + " are " + color + " and sometimes blue");
            Console.WriteLine(name + " is looking like " + food + " and so do you!");

            Console.WriteLine("Just kidding " + nameUser + " select a menu item to enjoy the fun.");

         

            List<string> menuItems = new List<string>()
            {
                "What is your name?",
                "Word-lib",
                "Calculator",
                "Game",
                "Exit"
                
            };


            Console.CursorVisible = false;
            while (true)
            {
                string userName, userAge;
                string selectedMenuItem = drawMenu(menuItems);
                if (selectedMenuItem == "What is your name?")
                {
                    Console.Clear();
                    Console.WriteLine("What is your name? ");
                    userName = Console.ReadLine();
                    Console.WriteLine("How old are you " + userName + "? ");
                    userAge = Console.ReadLine();
                    Console.WriteLine("My name is: " + userName +  "my age is: " + userAge );
                }else if (selectedMenuItem == "Word-lib")
                {
                    ;
                }
                else if (selectedMenuItem == "Calculator")
                {
                    Console.Clear();
                    Console.Write("Enter a number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Clear();
                    Console.Write("Enter operator: ");
                    string op = Console.ReadLine();

                    Console.Clear();
                    Console.Write("Enter a number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    if (op == "+")
                    {
                        Console.WriteLine(num1 + num2);
                    }else if (op == "-")
                    {
                        Console.WriteLine(num1 - num2);
                    }
                    else if (op == "/")
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else if (op == "*")
                    {
                       Console.WriteLine(num1 * num2);
                    }
                    else
                    {
                        Console.WriteLine("Invalid operator");
                    }

                }
                else if (selectedMenuItem == "Game")
                {
                    game.Game();
                }
                else if(selectedMenuItem == "Exit")
                {
                    Environment.Exit(0);
                }

          
                    
             
                


            }
        }

        private static string drawMenu(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(items[i]);
                }

                else
                {
                    Console.WriteLine(items[i]);

                }
                Console.ResetColor();

            }

            ConsoleKeyInfo Ckey = Console.ReadKey();

            if (Ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == items.Count - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            else if (Ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = items.Count - 1;
                }
                else
                {
                    index--;
                }



            }
            else if (Ckey.Key == ConsoleKey.Enter)
            {
                return items[index];
            }
            else
            {
                return "";
            }

            
            Console.Clear();
            return "";
        }

    }
}

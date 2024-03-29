using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using ConsoleApp;
using System.Threading.Tasks;
using ConsoleApp1;
using Firstc;
using Name;
using ConsoleColor = System.ConsoleColor;

namespace Opdracht1
{
    class Program
    {
        private static NameClass name = new NameClass();

        static void Main(string[] args)
        {

            //Forcing console window to fullscreen
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            //Change the color of the console to blue

            Console.WriteLine("Welcome to our console application! ");
            start();
        }

        //Method for starting the app
        public static void start()
        {

            Console.WriteLine("----------------------------");
            Console.WriteLine("Choose one of the following options: ");
            Console.WriteLine("1. Your name \n2. Your name is  \n3. Sum of two values \n4. Calculator \n5. Lottery \n6. Rock Paper Scissor  \n7. Change background color \n8. Guess game \n9. Quiz \n10. Exit the program");
            Console.WriteLine("----------------------------");

            //Switch statement for displaying the menu
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    name.enterName();
                    start();
                    break;
                case "2":
                    Console.Clear();
                    name.getName();
                    start();
                    break;
                case "3":
                    getValues();                 
                    break;
                case "4":
                    Console.Clear();
                    var calculator = new Calculator();
                    calculator.Calculate();
                    start();
                    break;
                case "5":
                    var gamble = new Lottery();
                    Console.Clear();                 
                    gamble.start();
                    break;
                case "6":
                    Console.Clear();
                    var rockPaperS = new RockPaperScissors();
                    rockPaperS.PlayRockPaperScissors();
                    start();
                    break;
                case "7":
                    Console.Clear();
                    var cs = new BackGroundColor();
                    cs.ColorChange();
                    start();
                    break;
                case "8":
                    Console.Clear();
                    var guessGame = new GuessGame();
                    guessGame.Game();
                    start();
                    break;
                case "9":
                    Console.Clear();
                    var quiz = new Quiz();
                    quiz.PlayQuiz();
                    start();
                    break;
                case "10":
                    Environment.Exit(-1);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("That's an invalid input try again! \n");
                    start();
                    break;
            }

        }
        public static void getValues()
        {
            Console.WriteLine("Value 1");
            int value1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Value 2");
            int value2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The sum is: " + (value1 + value2));
            start();
        }
    }
}


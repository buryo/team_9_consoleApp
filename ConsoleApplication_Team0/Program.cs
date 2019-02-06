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
            //Change the color of the console to blue
            start();
        }

        //Method for starting the app
        public static void start()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Welcome, choose one of the following options: ");
            Console.WriteLine("1. Your name \n2. Your name is  \n3. Calculator \n4. Gamble \n5. Rock Paper Scissor  \n6. Change background color \n7. Guess game \n8. Quiz \n9. Exit the program");
            Console.WriteLine("----------------------------");

            //Switch statement for displaying the menu
            switch (Console.ReadLine())
            {
                case "1":
                    name.enterName();
                    start();
                    break;
                case "2":
                    name.getName();
                    start();
                    break;
                case "3":
                    var calculator = new Calculator();
                    calculator.Calculate();
                    start();
                    break;
                case "4":
                    var gamble = new Gamble();
                    gamble.start();
                    start();
                    break;
                case "5":
                    var rockPaperS = new RockPaperScissors();
                    rockPaperS.PlayRockPaperScissors();
                    start();
                    break;
                case "6":
                    var cs = new BackGroundColor();
                    cs.ColorChange();
                    start();
                    break;
                case "7":
                    var guessGame = new GuessGame();
                    guessGame.Game();
                    start();
                    break;
                case "8":
                    var quiz = new Quiz();
                    quiz.PlayQuiz();
                    start();
                    break;
                case "9":
                    Environment.Exit(-1);
                    break;
                default:
                    Console.WriteLine("That's an invalid input try again! \n");
                    start();
                    break;
            }
        }
    }
}
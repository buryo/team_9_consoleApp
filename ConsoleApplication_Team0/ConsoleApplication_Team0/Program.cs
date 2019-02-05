using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using ConsoleApp;
using System.Threading.Tasks;
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
            Console.WriteLine("Welcome, choose one of the following options: ");
            Console.WriteLine("1. Your name \n2. Calculator \n3. Your name is \n4. Exit the program\n5. Gamble\n6. Change Color");

            //Switch statement for displaying the menu
            switch (Console.ReadLine())
            {
                case "1":
                    name.enterName();
                    start();
                    break;
                case "2":
                    getValue();
                    start();
                    break;
                case "3":
                    name.getName();
                    start();
                    break;
                case "4":
                    Environment.Exit(-1);
                    break;
                case "5":
                    Gamble gamble = new Gamble();
                    gamble.start();
                    start();
                    break;
                case "6":
                    BackGroundColor cs = new BackGroundColor();
                    cs.ColorChange();
                    start();
                    break;
                default:
                    Console.WriteLine("That's an invalid input try again! \n");
                    start();
                    break;
            }
        }
        //Method that adds two values
        public static void getValue()
        {
            double value1;
            double value2;
            Console.WriteLine("Enter two values\nvalue 1: ");
            value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Value 2: ");
            value2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(String.Format("The sum is: {0}\n", value1 + value2));
            start();
        }
    }
}
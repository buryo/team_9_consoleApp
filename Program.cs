using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {



            Console.Write("1:red:\n");
            Console.Write("2:green:\n");
            Console.Write("3:blue:\n");
            Console.Write("4:grey:\n");
            Console.Write("What is your favorite color: ");
            var color = Console.ReadLine();

            ///If the user types one of the 3 color's, then one one of the case blocks will run
            /// If the user chooses an other color that is not listed, the default block will run
            /// The font color will change too.
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("TADAAAAAA".PadLeft(60));
                    Console.ReadKey();
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("TADAAAAAA".PadLeft(60));
                    Console.ReadKey();
                    break;
                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("TADAAAAAA".PadLeft(60));
                    Console.ReadKey();
                    break;
                case "grey":
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("TADAAAAAA".PadLeft(60));
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("404 Color not found cowboy".PadLeft(50));
                    break;
            }
        }
    }
}

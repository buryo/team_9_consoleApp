using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht1;

namespace Firstc
{
    class Lottery
    {
        //A variable for the computer
        static Random rnd = new Random();
        private int[] playerArray = new int[5];
        //Array for the enemy to pick a random number between 1 and 6
        private int[] enemyArray = { rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6) };
        //Boolean to check if the enemyArray and PlayerArray are equal
        
        public void start()
        {
            Console.WriteLine("Try your luck with the lottery! Insert five numbers between 1-6 and check if you won the lottery");
        bool arrayCheck = true;
        int i = 0;
            //while loop for letting the player enter 5 values
            while (i < 5)
            {
                try
                {
                    Console.WriteLine(String.Format("Enter value: {0}", i+1));
                    playerArray[i] = Int32.Parse(Console.ReadLine());
                    if (playerArray[i] >= 0 && playerArray[i] < 6)
                    {
                        //Do nothing
                    }
                    else
                    {
                        //Start over
                        Console.WriteLine("Please pick a number between 1-6"); 
                        start();
                        
                    }
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Please enter a number between 1 and 6");
                    start();
                }
                i++;
            }
            //Shows the players input.
            Console.Write("Your input: ");
            foreach (var ea in playerArray)
            {
                Console.Write(ea);
            }

            Console.WriteLine("");

            Console.Write("Computer input: ");
            foreach (var ea in enemyArray)
            {
                Console.Write(ea);
            }
            //If the user array is not equal to the enemyarray then the player lost
            for (int j = 0; j < 5; j++)
            {
                if (!playerArray[j].Equals(enemyArray[j]))
                {
                    arrayCheck = false;
                }
            }

            if (arrayCheck)
            {
                Console.WriteLine("\nYou won!");
            }
            else
            {
                Console.WriteLine("\nYou lost!");
            }

            //Switch case to play the game again
            Console.WriteLine("Wanna play again? Y/N");
            switch (Console.ReadLine())
            {
                case "Y":
                case "y":
                    start();
                    break;
                case "N":
                case "n":
                    var Program = new Program();
                    Program.start();
                    break;
                default:
                    start();
                    break;
            }
        }
    }
}
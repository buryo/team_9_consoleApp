using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht1;

namespace Firstc
{
    class Gamble
    {
        //A variable for the computer
        static Random rnd = new Random();
        private int[] playerArray = new int[5];
        //Array for the enemy to pick a random number between 1 and 6
        private int[] enemyArray = { rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6) };
        //Boolean to check if the enemyArray and PlayerArray are equal
        
        public void start()
        {
        bool arrayCheck = true;
        int i = 0;
            //while loop for letting the player enter 5 values
            while (i < 5)
            {
                try
                {
                    Console.WriteLine(String.Format("Enter value: {0}", i));
                    playerArray[i] = Int32.Parse(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Please enter a number between 1 and 6");
                    start();
                }
                i++;
            }
            //Shows the players input.
            foreach (var ea in playerArray)
            {
                Console.Write(ea);
            }

            Console.WriteLine("");

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
                Console.WriteLine("You won!");

            }
            else
            {
                Console.WriteLine("You lost!");

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
                    break;
            }
        }
    }
}
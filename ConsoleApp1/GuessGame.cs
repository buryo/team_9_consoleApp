using System;

namespace ConsoleApp1
{
    class GuessGame
    {
        public void Game()
        {
            Console.WriteLine("Player 1 what is your name?");
            string player1 = Console.ReadLine();

            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("Player 2 what is your name?");
            string player2 = Console.ReadLine();

            Console.WriteLine("--------------------------------------------------------------");


            Console.WriteLine(player1 + " vs " + player2);


            Console.WriteLine("Let the game begin!");

            Console.WriteLine("Guess the number! hint: between 0 and 1000");

            Console.WriteLine("--------------------------------------------------------------");



            //this variable generates a random number between 1 and 999 (minValue is included, maxValue is not included)
            Random random = new Random();
            int winNumber = random.Next(1, 1000);

            //variable win is false till player wins. 
            bool win = false;

            int playerTurn = 1;

            //do loop which loops till number is guessed right. 
            do
            {
                
                if (playerTurn == 1)
                {
                    Console.Write("Guess the number " + player1 + ": ");

                    Console.WriteLine("--------------------------------------------------------------");

                }
                else
                {
                    Console.Write("Guess the number " + player2 + ": ");

                    Console.WriteLine("--------------------------------------------------------------");

                }
                string answer = Console.ReadLine();

                //This turns the turn between 1 and 2
                if (playerTurn == 1)
                {
                    playerTurn = 2;
                }
                else
                {
                    playerTurn = 1;
                }


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
}

using System;

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
}

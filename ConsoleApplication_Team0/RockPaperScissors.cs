using System;

namespace Opdracht1
{
    internal class RockPaperScissors
    {
        private string inputPlayer, inputComputer;
        private int randomInt;
        private int scorePlayer;
        private int scoreComputer;


        public void PlayRockPaperScissors()
        {
            Console.Clear();


            while (scorePlayer < 3 && scoreComputer < 3)
            {
                Console.WriteLine("Please choose Rock, Paper or Scissors!");
                inputPlayer = Console.ReadLine();

                var rnd = new Random();
                randomInt = rnd.Next(1, 4);
                Console.Clear();

                switch (randomInt)
                {
                    case 1:
                        inputComputer = "rock";
                        Console.WriteLine("Computer chose rock!");
                        if (inputPlayer == "rock" || inputPlayer == "Rock" || inputPlayer == "ROCK")
                        {
                            Console.WriteLine("it's a draw");
                        }
                        else if (inputPlayer == "paper" || inputPlayer == "Paper" || inputPlayer == "PAPER")
                        {
                            Console.WriteLine("Player wins!");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "scissors" || inputPlayer == "Scissors" || inputPlayer == "Scissors")
                        {
                            Console.WriteLine("Computer wins!");
                            scoreComputer++;
                        }

                        break;

                    case 2:
                        inputComputer = "paper";
                        Console.WriteLine("Computer chose paper!");
                        if (inputPlayer == "rock" || inputPlayer == "Rock" || inputPlayer == "ROCK")
                        {
                            Console.WriteLine("Computer wins!");
                            scoreComputer++;
                        }
                        else if (inputPlayer == "paper" || inputPlayer == "Paper" || inputPlayer == "PAPER")
                        {
                            Console.WriteLine("it's a draw!");
                        }
                        else if (inputPlayer == "scissors" || inputPlayer == "Scissors" || inputPlayer == "Scissors")
                        {
                            Console.WriteLine("Player wins!");
                            scorePlayer++;
                        }

                        break;

                    case 3:
                        inputComputer = "scissors";
                        Console.WriteLine("Computer chose scissors!");
                        if (inputPlayer == "rock" || inputPlayer == "Rock" || inputPlayer == "ROCK")
                        {
                            Console.WriteLine("Player won!");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "paper" || inputPlayer == "Paper" || inputPlayer == "PAPER")
                        {
                            Console.WriteLine("Computer wins!");
                            scoreComputer++;
                        }
                        else if (inputPlayer == "scissors" || inputPlayer == "Scissors" || inputPlayer == "Scissors")
                        {
                            Console.WriteLine("It's a draw!");
                        }

                        break;
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player wins the game! your score was {0}", scorePlayer);
                    Console.WriteLine("The computer won {0} time(s)...", scoreComputer);
                }
                else if (scoreComputer == 3)
                {
                    Console.WriteLine("Computer wins the game!, his score was {0}", scoreComputer);
                    Console.WriteLine("You only won {0} time(s)...", scorePlayer);
                }
            }
        }
    }
}
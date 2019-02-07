using System;

namespace ConsoleApp1
{
    internal class GuessGame
    {
        public void Game()
        {
            Console.WriteLine("Player 1 what is your name?");
            var player1 = Console.ReadLine();

            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("Player 2 what is your name?");
            var player2 = Console.ReadLine();

            Console.WriteLine("--------------------------------------------------------------");


            Console.WriteLine(player1 + " vs " + player2);


            Console.WriteLine("Let the game begin!");

            Console.WriteLine("Guess the number! hint: between 0 and 1000");

            Console.WriteLine("--------------------------------------------------------------");


            //this variable generates a random number between 1 and 999 (minValue is included, maxValue is not included)
            var random = new Random();
            var winNumber = random.Next(1, 1000);

            //variable win is false till player wins. 
            var win = false;

            var playerTurn = 1;

            //do loop which loops till number is guessed right. 
            do
            {
                try
                {
                    if (playerTurn == 1)
                    {
                        Console.WriteLine("Guess the number " + player1 + ": ");

                        Console.WriteLine("--------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Guess the number " + player2 + ": ");

                        Console.WriteLine("--------------------------------------------------------------");
                    }

                    var answer = Console.ReadLine();

                    //This turns the turn between 1 and 2
                    if (playerTurn == 1)
                        playerTurn = 2;
                    else
                        playerTurn = 1;

                    //variable answer gets parsed into int i
                    var i = int.Parse(answer);
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
                        Console.Clear();
                        Console.WriteLine(
                            "            -----    -----      ---------       -----    -----       -----                   -----      ---------        -------     -----      ---                       ");
                        Console.WriteLine(
                            "              ---   -----    -----     -----    -----    -----        -----                 -----    -----     -----     --------    -----     -----                              ");
                        Console.WriteLine(
                            "               -- -----     -----       -----   -----    -----         -----       -       -----    -----       -----    ----- ---   -----     -----                                ");
                        Console.WriteLine(
                            "                ------      -----       -----   -----    -----          -----    -----    -----     -----       -----    -----  ---  -----      ---                                ");
                        Console.WriteLine(
                            "                -----        -----     -----    ----- -- -----           -----  --   --  -----       -----     -----     -----   --- -----                               ");
                        Console.WriteLine(
                            "               -----            ---------         ----------              --------    -------           ---------        -----    --------      ---                                  ");
                        win = true;
                        Console.WriteLine("Wanna play again? Y/N");
                        switch (Console.ReadLine())
                        {
                            case "Y":
                            case "y":
                                Game();
                                break;
                            case "N":
                            case "n":
                                break;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a number, you lost a turn!");
                }
            } while (win == false);
        }
    }
}

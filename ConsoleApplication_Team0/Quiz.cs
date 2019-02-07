using System;

namespace Opdracht1
{
    internal class Quiz
    {
        private string userInput1;
        private string userInput2;
        private string userInput3;
        private string userInput4;
        private string userInput5;
        private string userInput6;
        private string userInput7;
        private string userInput8;
        private string userInput9;
        private string userInput10;
        private int score;

        public void PlayQuiz()
        {
            Console.Clear();
            Console.WriteLine("Welcome to our C# quiz! Test your C# knowledge in this quick test.");
            Console.WriteLine();

            //Question #1
            Console.WriteLine("Does C# support multipile inhertitance?");
            userInput1 = Console.ReadLine();

            if (string.Equals(userInput1, "no", StringComparison.CurrentCultureIgnoreCase) ||
                string.Equals(userInput1, "false", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Correct");
                score++;
            }
            else
            {
                Console.WriteLine("False, the correct answer is no!");
            }

            Console.WriteLine();

            //Question #2
            Console.WriteLine("What is the top .NET class that everything else in C# is derived from");
            userInput2 = Console.ReadLine();
            if (userInput2 == "System.Object")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("False! That is not the top class in C#. The correct answer is = 'System.Object'");
            }

            Console.WriteLine();

            //Question #3
            Console.WriteLine("Can a class implement multipile interfaces in C#?");
            userInput3 = Console.ReadLine();
            if (string.Equals(userInput3, "yes", StringComparison.CurrentCultureIgnoreCase) ||
                string.Equals(userInput3, "true", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("False! Classes can implement any number of interfaces they like!");
            }

            Console.WriteLine();

            //Question #4
            Console.WriteLine(
                "Example: I have a class which has 2 methods with the exact same name but 2 different parameters. What is this called?");
            userInput4 = Console.ReadLine();
            if (string.Equals(userInput4, "overloading", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine(
                    "False! The correct answer is 'overloading'. Overloading occurs when a class has 2 methods with the same name but different parameters." +
                    Environment.NewLine +
                    "Overriding on the otherhand is when a class has 2 methods with the EXACT same name AND parameters");
            }

            Console.WriteLine();

            //Question #5
            Console.WriteLine(
                "C# delegate can be used when passing a reference to a method, True or False?");
            userInput5 = Console.ReadLine();
            if (string.Equals(userInput5, "true", StringComparison.CurrentCultureIgnoreCase) ||
                string.Equals(userInput5, "yes", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine(
                    "False! The correct answer is 'overloading'. Overloading occurs when a class has 2 methods with the same name but different parameters." +
                    Environment.NewLine +
                    "Overriding on the otherhand is when a class has 2 methods with the EXACT same name AND parameters");
            }

            Console.WriteLine();

            //Question #6
            Console.WriteLine("How many Bytes can be stored when using Long datatype?");
            userInput6 = Console.ReadLine();
            if (string.Equals(userInput6, "8", StringComparison.CurrentCultureIgnoreCase) ||
                string.Equals(userInput6, "eight", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("False! The correct answer is '8 bytes'");
            }

            Console.WriteLine();

            //Question #7
            Console.WriteLine("A little bit of history, Did Java steal C# from windows and then call it J#?");
            userInput7 = Console.ReadLine();
            if (string.Equals(userInput7, "no", StringComparison.CurrentCultureIgnoreCase) ||
                string.Equals(userInput7, "false", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Correct! you know your history");
                score++;
            }
            else
            {
                Console.WriteLine("Go back to Slide 1 on Rudy's lesson please");
            }

            Console.WriteLine();

            //Question #8
            Console.WriteLine("Normally speaking, how many values does a function return in C#?");
            userInput8 = Console.ReadLine();
            if (string.Equals(userInput8, "1", StringComparison.InvariantCultureIgnoreCase) ||
                string.Equals(userInput8, "false", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine(
                    "False! In C#, the standard amount of returned values is 1, there are ofcourse ways to return multipile values but the standard amount of returned values is one");
            }

            Console.WriteLine();

            //Question #9
            Console.WriteLine("In C#, can a class inherit a destructor?");
            userInput9 = Console.ReadLine();
            if (string.Equals(userInput9, "no", StringComparison.CurrentCultureIgnoreCase) ||
                string.Equals(userInput9, "false", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("False! a Destructor cannot be inherited!");
            }

            Console.WriteLine();

            //Question #10
            Console.WriteLine("Does a destructor return a value?");
            userInput10 = Console.ReadLine();
            if (string.Equals(userInput10, "no", StringComparison.CurrentCultureIgnoreCase) ||
                string.Equals(userInput10, "false", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("False! a Destructor doesn't inherit anything");
            }

            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Congratulations, you finished the C# Console Quiz! Your score was {0} out of 10.",
                score);
            Console.WriteLine();
        }
    }
}
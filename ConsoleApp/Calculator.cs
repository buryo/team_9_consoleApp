using System;
using System.Linq;

namespace ConsoleApp
{
    class Calculator
    {
        private static readonly string[] operations = { "+", "-", "*", "/" };

        /// <summary>
        ///     Method to set number which can be used to calculate
        /// </summary>
        /// <param name="outputText"></param>
        /// <returns> double tempInput </returns>
        private static double SetNumber(string outputText)
        {
            double parse;
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!double.TryParse(tempInput, out parse))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return double.Parse(tempInput);
        }

        /// <summary>
        ///     Method to define operator which we are going to use
        /// </summary>
        /// <param name="outputText"></param>
        /// <returns> String tempInput</returns>
        private static string SetOperation(string outputText)
        {
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!IsValidOperation(tempInput))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return tempInput;
        }

        /// <summary>
        ///     Method where we check if our operations contains the given operator
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool IsValidOperation(string input)
        {
            return operations.Contains(input);
        }

        /// <summary>
        /// Main method where all the Math happens
        /// Returns with CW(result of math)
        /// </summary>
        public void Calculate()
        {
            double result;
            double num1 = SetNumber("Type you first number : ");

            string op = SetOperation("Enter operator: ");

            double num2 = SetNumber("Type you second number : ");

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    result = 0;
                    break;
            }
            Console.WriteLine("Result {0}", result);
            Console.ReadKey();
        }
    }
}

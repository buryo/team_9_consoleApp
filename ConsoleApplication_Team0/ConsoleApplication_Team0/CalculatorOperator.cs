using System;

namespace CalculatorModule
{
    internal class CalculatorOperator
    {
        public void Calculate()
        {
            Console.Clear();
            Console.Write("Enter the first number: ");
            var number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator: ");
            var op = Console.ReadLine();

            Console.Write("Enter the second number: ");
            var number2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
                Console.WriteLine(number1 + number2);

            else if (op == "-")
                Console.WriteLine(number1 - number2);

            else if (op == "/")
                Console.WriteLine(number1 / number2);

            else if (op == "*")
                Console.WriteLine(number1 * number2);

            else
                Console.Write("Invalid Operator");

            Console.ReadLine();
        }
    }
}
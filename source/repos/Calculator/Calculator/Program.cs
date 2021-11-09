using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");

            Console.WriteLine("Enter the operator: ");
            string operatorInput = Console.ReadLine();

            Console.Write("Enter the first number: ");
            string firstInput = Console.ReadLine();
            // Parsing user string to an int for calculation
            int firstNumber = int.Parse(firstInput);


            Console.Write("Enter the second number: ");
            string secondInput = Console.ReadLine();
            // Parsing user string to an int for calculation
            int secondNumber = int.Parse(secondInput);

            int result = 0;

            if (operatorInput == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operatorInput == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operatorInput == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (operatorInput == "/")
            {
                result = firstNumber / secondNumber;
            }
            else
            {
                Console.WriteLine("Please input a valid operator.");
            }

            Console.WriteLine("Your result is: " + result);
            Console.ReadLine();
        }
    }
}

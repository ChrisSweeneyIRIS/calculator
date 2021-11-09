using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");

            Console.Write("Enter the first number: ");
            string firstInput = Console.ReadLine();
            // Parsing user string to an int for calculation
            int firstNumber = int.Parse(firstInput);


            Console.Write("Enter the second number: ");
            string secondInput = Console.ReadLine();
            // Parsing user string to an int for calculation
            int secondNumber = int.Parse(secondInput);

            int result = firstNumber * secondNumber;
            Console.WriteLine("Your result is: " + result);

            Console.ReadLine();
        }
    }
}

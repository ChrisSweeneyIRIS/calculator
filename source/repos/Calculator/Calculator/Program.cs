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

            string operatorWord = "";

            Console.WriteLine("How many numbers would you like to " + operatorWord + "?");
            int numberInput = int.Parse(Console.ReadLine());

            int[] numbers = new int[numberInput];
            for (int index = 0; index < numberInput; index++)
            {
                Console.Write("Please enter number " + (index + 1) + ": ");
                numbers[index] = int.Parse(Console.ReadLine());
            }

            int result = 0;

            // Used sample solution to help with finishing this exercise
            for (int index = 1; index < numberInput; index++)
            {
                if (operatorInput == "+")
                {
                    result = result + numbers[index];
                    operatorWord = "add";
                }
                else if (operatorInput == "-")
                {
                    result = result - numbers[index];
                    operatorWord = "subtract";
                }
                else if (operatorInput == "*")
                {
                    result = result * numbers[index];
                    operatorWord = "multiply";
                }
                else if (operatorInput == "/")
                {
                    result = result - numbers[index];
                    operatorWord = "divide";
                }
                else
                {
                    Console.WriteLine("Please input a valid operator.");
                }
            }

            Console.WriteLine("Your result is: " + result);
            Console.ReadLine();
        }
    }
}

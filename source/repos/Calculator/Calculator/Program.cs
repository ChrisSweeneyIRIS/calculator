using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            welcomeMessage();

            bool displayCalculator = true;
            while (displayCalculator == true)
            {
                performCalculation();
            }
        }

        private static void welcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine("--------------------------");
        }

        private static string userOperator()
        {
            Console.Write("Enter the operator: ");
            string operatorInput = Console.ReadLine();

            return operatorInput;
        }

        private static void performCalculation()
        {
            var operatorInput = userOperator();
            var numbers = userArray(operatorInput);
            var result = calculateResult(operatorInput, numbers);

            Console.WriteLine("Your result is: " + result);
            Console.WriteLine();
        }

        // Tried to use "{0}, operatorInput " instead of [text] + operator input + [question mark] but seems to only work when using WriteLine
        private static int[] userArray(string operatorInput)
        {
            var count = userNumber("How many numbers do you want to " + operatorInput + "? ");

            int[] numbers = new int[count];
            for (int index = 0; index < count; index++)
            {
                numbers[index] = userNumber("Enter number " + (index + 1) + ": ");
            }
            return numbers;
        }

        private static int userNumber(string message)
        {
            int count;

            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out count));

            return count;
        }
        /* Had to use method from solution to adapt my existing method that I tried to adapt. 
         * Removed "operatorWord" variable as I struggled to get it in scope and it was unnecessary.
         */
        private static int calculateResult(string operatorInput, int[] numbers)
        {
            int result = numbers[0];
            for (int index = 1; index < numbers.Length; index++)
            {
                if (operatorInput == "+")
                {
                    result = result + numbers[index];
                }
                else if (operatorInput == "-")
                {
                    result = result - numbers[index];
                }
                else if (operatorInput == "*")
                {
                    result = result * numbers[index];
                }
                else if (operatorInput == "/")
                {
                    result = result / numbers[index];
                }
                /* Due to implementation, this was commented out.
                 else
                {
                    Console.WriteLine("Please input a valid operator.");
                } */
            }
            return result;
        }
    }
}
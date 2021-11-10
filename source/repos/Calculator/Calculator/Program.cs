using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;

        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = mainMenu();
            }
        }

        private static bool mainMenu()
        {
            welcomeMessage();
        
            Console.WriteLine("1) Numbers");
            Console.WriteLine("2) Dates");
            Console.WriteLine("3) Exit");
            string menuInput = Console.ReadLine();

            if (menuInput == "1")
            {
                numberCalculator();
                return true;

            }
            else if (menuInput == "2")
            {
                dateCalculator();
                return true;
            }
            else if (menuInput == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void welcomeMessage()
        {
            Console.WriteLine("Welcome to the calculator, please choose an option: ");
            Console.WriteLine("----------------------------------------------------");
        }

        private static void numberCalculator()
        {
            performCalculation();
        }

        private static void dateCalculator()
        {
            performDateCalculation();
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

        private static void performDateCalculation()
        {
            var date = userDate("Enter a date: ");
            var number = userNumber("Enter the number of days to be added: ");

            var result = date.AddDays(number);

            Console.WriteLine("The date result is: " + result);
            Console.ReadLine();
        }

        private static DateTime userDate(string message)
        {
            DateTime date;

            do
            {
                Console.WriteLine(message);
            } while (!DateTime.TryParse(Console.ReadLine(), out date));
            return date;
        }
    }
}

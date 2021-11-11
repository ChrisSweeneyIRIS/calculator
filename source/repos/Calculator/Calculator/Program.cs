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
            new NumberCalculator().performCalculation();
        }

        private static void dateCalculator()
        {
            new DateCalculator().PerformDateCalculation();
        }


    }
}

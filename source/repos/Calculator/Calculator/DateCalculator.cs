using System;

public class DateCalculator
{
	public void  PerformDateCalculation()
	{

            var date = Prompts.userDate("Enter a date: ");
            var number = Prompts.userNumber("Enter the number of days to be added: ");

            var result = date.AddDays(number);

        // Wrote result like this as doing it using squiggly braces & formatting caused errors
        Console.WriteLine("The date result is: " + result);
            Console.ReadLine();
       
    }
}

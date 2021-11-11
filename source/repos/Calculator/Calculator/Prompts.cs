using System;

public class Prompts
{
    public static int userNumber(string message)
    {
        int count;

        do
        {
            Console.Write(message);
        } while (!int.TryParse(Console.ReadLine(), out count));

        return count;
    }

    public static DateTime userDate(string message)
    {
        DateTime date;

        do
        {
            Console.WriteLine(message);
        } while (!DateTime.TryParse(Console.ReadLine(), out date));
        return date;
    }

    public static int[] userArray(string operatorInput)
    {
        var count = userNumber("How many numbers do you want to " + operatorInput + "? ");

        int[] numbers = new int[count];
        for (int index = 0; index < count; index++)
        {
            numbers[index] = userNumber("Enter number " + (index + 1) + ": ");
        }
        return numbers;
    }
}

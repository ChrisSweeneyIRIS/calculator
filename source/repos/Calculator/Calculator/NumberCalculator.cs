using System;

public class NumberCalculator
{
    public static string userOperator()
    {
        Console.Write("Enter the operator: ");
        string operatorInput = Console.ReadLine();

        return operatorInput;
    }

    public void performCalculation()
    {
        var operatorInput = userOperator();
        var numbers = Prompts.userArray(operatorInput);
        var result = calculateResult(operatorInput, numbers);

        Console.WriteLine("Your result is: " + result);
        Console.WriteLine();
    }

    public static int calculateResult(string operatorInput, int[] numbers)
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
        }
        return result;
    }
}

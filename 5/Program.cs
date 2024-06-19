using System;

public class Program
{
    public static void Main()
    {
        int number = 5;
        long factorial = CalculateFactorial(number);
        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }

    public static long CalculateFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Number must be non-negative");
        }

        if (n == 0 || n == 1)
        {
            return 1;
        }

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}
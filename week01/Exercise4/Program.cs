using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //ask the user fot a list of numbers
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string user = Console.ReadLine();
            userNumber = int.Parse(user);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        // 1. Calculate sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
        // Part 2: Compute the average
        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average is: {average}");
        // 3. Find the maximum number
        int MaxNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > MaxNumber)
            {
                MaxNumber = number;
            }
        }
        Console.WriteLine($"The Max is: {MaxNumber}");
    }

}
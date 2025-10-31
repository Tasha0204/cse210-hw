using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks the user for their rating percentage
        Console.WriteLine("Enter your grade percentage:");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

       string lettergrade = "";
        

        if (percentage >= 90)
        {
            lettergrade= "A";
        }
        else if (percentage >= 80)
        {
            lettergrade= "B";
        }
        else if (percentage >= 70)
        {
            lettergrade= "C";
        }
        else if (percentage >= 60)
        {
            lettergrade= "D";
        }
        else
        {
            lettergrade= "F";
        }
        Console.WriteLine($"Your grade is: {lettergrade}");
        if (percentage >= 70)
        {
            Console.WriteLine("You did it, you passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time. You can do it with a little more effort, don't give up!");
        }
    }
}
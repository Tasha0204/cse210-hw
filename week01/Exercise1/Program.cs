using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for their name.
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your Last name?");
        string LastName = Console.ReadLine();
     
        Console.WriteLine($"Your name is {LastName}, {firstName} {LastName}.");

    }
}
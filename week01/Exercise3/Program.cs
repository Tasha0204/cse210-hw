using System;

class Program
{
    static void Main(string[] args)
    {
        //ask the user for a magic number between 1 and 100.
        // Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        //cosole.write("What is your guess?");
        //int guess = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess < magicNumber)
            {
                Console.WriteLine("higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
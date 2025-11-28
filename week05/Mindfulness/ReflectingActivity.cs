using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you do that made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
    };

    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayQuestions()
    {
        DateTime futureTime = GetFutureTime(GetDuration());
        
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine($"> {GetRandomQuestion()}");
            ShowSpinner(10);
        }
    }

    public void Run() 
    {
        DisplayStartingMessage();
        
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now, ponder on each of the following questions as they relate to that experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();
        Console.Clear();

        DisplayQuestions();

        DisplayEndingMessage();
    }
}
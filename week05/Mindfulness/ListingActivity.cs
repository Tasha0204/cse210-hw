using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are some of your personal heroes?",
        "When have you felt the Holy Ghost this month?",
        "Who have you helped this week?",
    };

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> userItems = new List<string>();
        DateTime futureTime = GetFutureTime(GetDuration());

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            userItems.Add(Console.ReadLine());
        }
        return userItems;
    }

    public void Run() 
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        List<string> items = GetListFromUser();
        _count = items.Count;
        
        Console.WriteLine($"You listed {_count} items!");
        
        DisplayEndingMessage();
    }
}
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void Run() 
    {
        DisplayStartingMessage();

        Console.WriteLine();
        
        DateTime futureTime = GetFutureTime(GetDuration());
        
        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine();
            
            Console.Write("Now Breathe out...");
            ShowCountdown(6);
            Console.WriteLine();
            Console.WriteLine();
        }
        
        DisplayEndingMessage();
    }
}
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",

        "What was the best part of my day?",

        "How did I perceive God's presence in my life today?",  

        "What was the most intense emotion I felt today?",

        "If I could relive any moment of today, what would it be?",

        "What did I learn today that surprised me?",
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public Entry()
    {
        _date = "";
        _promptText = "";
        _entryText = "";
    }
      public Entry(string prompt, string text)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = prompt;
        _entryText = text;
    }
      public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}\n");
    }
}
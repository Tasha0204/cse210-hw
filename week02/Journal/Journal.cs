using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("I'm sorry, your diary is empty. Please write something first.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine();
    }


    public void SaveToFile(string file)
    {
        string separator = "~|~"; 
        try
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    
                    outputFile.WriteLine($"{entry._date}{separator}{entry._promptText}{separator}{entry._entryText}");
                }
            }
            Console.WriteLine($"\n We have successfully saved your text to your journal: {file}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n Error saving the document to your journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string separator = "~|~";

        try
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split(separator);

                if (parts.Length == 3)
                {
                    Entry newEntry = new Entry();
                    newEntry._date = parts[0];
                    newEntry._promptText = parts[1];
                    newEntry._entryText = parts[2];

                    _entries.Add(newEntry);
                }
            }
            Console.WriteLine($"\n We have successfully loaded your journal information from: {file}.Total entries:{_entries.Count}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"\n Error loading file {file} The path you specified is incorrect..");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n  {ex.Message}");
        }
    }
    public void FilterByDate(string date)
    {
         Console.WriteLine($"\n  Entries on {date}");
          bool found = false;
         
         foreach (Entry entry in _entries)
          {
            if (entry._date == date) 
           {
            entry.Display();
            found = true;
           }
          }

            if (!found)
           {
            Console.WriteLine($"No entries found for the date: {date}.");
         }
           Console.WriteLine();
    }
}
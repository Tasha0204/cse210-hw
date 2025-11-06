using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO THE JOURNAL PROGRAM");

        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                
                Console.Write("> ");
                string response = Console.ReadLine();
                
              
                Entry newEntry = new Entry(prompt, response);
                myJournal.AddEntry(newEntry);
                
            }
            else if (choice == "2")
            {
                
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                 Console.Write("Please enter the name of your previously saved journal or file (e.g., programming_diary.txt): ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
                
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
               
            }
            else if (choice == "5")
            {
                Console.WriteLine();
            }
        }
    }
}
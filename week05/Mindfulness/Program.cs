using System;
using System.Collections.Generic; 
//I decided to implement a code called DisplayLog(), which allows the user to see how many times each option in the main menu has been executed.
class Program
{
    static void Main(string[] args)
    {
        string input = "";
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

    
      void DisplayLog()
        {
            Console.WriteLine("Activity Log - Current Session");
            Console.WriteLine($"Breathing Activity: {breathingLog}");
            Console.WriteLine($"Reflecting Activity: {reflectingLog}");
            Console.WriteLine($"Listing Activity: {listingLog}");
            Console.WriteLine();
        }

        while (input != "4")
        {
            Console.Clear();
            DisplayLog();


            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    breathingLog++; 
                    break;

                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                  
                    reflectingActivity.Run();
                    reflectingLog++;
                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                  
                    listingActivity.Run();
                    listingLog++; 
                    break;

                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    break;
                    
                default:
                    Console.WriteLine("Please enter the number of the menu option. Press ENTER to continue.");
                    Console.ReadLine();
                    break;
            }
        }
   
    }
}
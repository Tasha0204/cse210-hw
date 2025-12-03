using System;
//Inclement, a code to measure the level based on the total accumulated points, which are level 1 Beginner, level 2 Journeyman, level 3 Master
public class Program
{
    public static void Main(string[] args)
    {
        GoalsTracker tracker = new GoalsTracker();
        int choice = 0;

        do
        {
            
            int currentPoints = tracker.GetAccumulatedPoints();
            string level = CalculateLevel(currentPoints);
            
            Console.WriteLine($"Your level is: {level} ");
            Console.WriteLine($"You have {currentPoints} points");
            Console.WriteLine();
            

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1: 
                        CreateGoalMenu(tracker);
                        break;
                    case 2: 
                        tracker.ListGoals();
                        break;
                    case 3: 
                        tracker.SaveGoals();
                        break;
                    case 4: 
                        tracker.LoadGoals();
                        break;
                    case 5: 
                        tracker.ListGoals();
                        tracker.RecordEventInTracker();
                        break;
                    case 6: 
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            Console.WriteLine();
        } while (choice != 6);
    }
    
    public static void CreateGoalMenu(GoalsTracker tracker)
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        
        if (int.TryParse(Console.ReadLine(), out int typeChoice))
        {
            Goal newGoal = null;
            switch (typeChoice)
            {
                case 1:
                   
                    newGoal = new SimpleGoal("temp", "temp", 0, false); 
                    break;
                case 2:
                    newGoal = new EternalGoal("temp", "temp", 0, 0); 
                    break;
                case 3:
                    newGoal = new ChecklistGoal("temp", "temp", 0, 0, 0, 0); 
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    return;
            }
            newGoal.CreateChildGoal(); 
            tracker.addGoal(newGoal);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
    
    public static string CalculateLevel(int points)
    {
        if (points >= 5000)
        {
            return "Master (Level 3)";
        }
        else if (points >= 1000)
        {
            return "Journeyman (Level 2)";
        }
        else
        {
            return "Beginner (Level 1)";
        }
    }
}
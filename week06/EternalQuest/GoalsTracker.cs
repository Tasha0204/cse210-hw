using System;
using System.Collections.Generic;
using System.Linq;

public class GoalsTracker
{
 
    private List<Goal> _goals = new List<Goal>(); 
    private int _accumulatedPoints = 0; 

    public int GetAccumulatedPoints() {
        return _accumulatedPoints;
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++) {
            Console.Write($"{i + 1}. ");
            _goals[i].ListGoal();
            Console.Write("\n");
        }
        Console.WriteLine();
    }
    
    public void addGoal(Goal goal)
    {
        _goals.Add(goal); 
    }

    public void RecordEventInTracker()
    {
        Console.Write("Which goal did you accomplish? (Enter the number) ");
        int goalIndexInt = Convert.ToInt32(Console.ReadLine()) - 1;

        if (goalIndexInt < 0 || goalIndexInt >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal selectedGoal = _goals[goalIndexInt];
        
     
        if (selectedGoal.GetType().Name == "SimpleGoal" && selectedGoal.IsComplete())
        {
            Console.WriteLine("You have already completed this goal.");
            return;
        }

        selectedGoal.RecordEvent();

        int pointsEarned = selectedGoal.CalculateAGP();
        _accumulatedPoints += pointsEarned;

        Console.WriteLine($"Congratulations! You have earned {pointsEarned.ToString()} points!");
        Console.WriteLine($"You now have {_accumulatedPoints} points");
    }

    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_accumulatedPoints.ToString());
            
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear(); 
        _accumulatedPoints = 0;

        string fileName = "";
        Console.Write("What is the filename to load? ");
        fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine($"Error: File '{fileName}' not found.");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(fileName);

        if (lines.Length > 0)
        {
             _accumulatedPoints = Convert.ToInt32(lines[0]);
        }
       
        for (int i = 1; i < lines.Count(); i++ )
        {
            string[] parts = lines[i].Split(",");

            if (parts[0] == "SimpleGoal") {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                addGoal(simpleGoal); 
            } else if (parts[0] == "EternalGoal") {
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]));
                addGoal(eternalGoal);
            } else if (parts[0] == "ChecklistGoal") {
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
                addGoal(checklistGoal);
            }
        }
    }
}
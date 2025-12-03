using System;

public abstract class Goal
{
   
    protected string _shortName;
    protected string _description;
    protected int _points;

  
    public Goal() {} 


    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    protected void CreateBaseGoal() 
    { 
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
    }
    public abstract string SaveGoal(); 
    public abstract void CreateChildGoal();
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract void ListGoal();
    public abstract int CalculateAGP();
    
    public int GetPoints()
    {
        return _points;
    }
}
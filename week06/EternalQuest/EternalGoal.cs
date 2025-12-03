using System;

public class EternalGoal : Goal
{
    private int _stepCounter;

    public EternalGoal(string name, string description, int points, int stepCounter)
        : base(name, description, points)
    {
        _stepCounter = stepCounter;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();
        _stepCounter = 0;
    }

    public override void ListGoal()
    {
        Console.Write($"[ ] {_shortName} ({_description}) -- Logged {_stepCounter} times"); 
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        _stepCounter ++;
    }
    
    public override int CalculateAGP()
    {
        return _points;
    }

    public override string SaveGoal()
    {
        return $"EternalGoal,{_shortName},{_description},{_points},{_stepCounter}";
    }
}
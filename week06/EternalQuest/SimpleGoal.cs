using System;

public class SimpleGoal : Goal
{
    private bool _isComplete; 


    public SimpleGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (_isComplete == false) {
            _isComplete = true;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void ListGoal()
    {
        string statusSymbol = IsComplete() ? "X" : " ";
        Console.Write($"[{statusSymbol}] {_shortName} ({_description})");
    }
    
    public override int CalculateAGP()
    {
        return _isComplete ? _points : 0;
    }

    public override string SaveGoal()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points},{_isComplete}";
    }
}
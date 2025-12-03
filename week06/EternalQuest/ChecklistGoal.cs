using System;


public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _target; 
    private int _amountCompleted; 

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int target, int amountCompleted)
        : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _target = target;
        _amountCompleted = amountCompleted;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _target = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = Convert.ToInt32(Console.ReadLine());

        _amountCompleted = 0;
    }

    public override bool IsComplete() 
    {
        return _amountCompleted >= _target;
    }
    
    public override void RecordEvent()
    {
        if (!IsComplete()) 
        {
            _amountCompleted++;
        }
    }

    public override int CalculateAGP()
    {
        int points = _points; 

        if (_amountCompleted == _target) 
        {
             points += _bonusPoints;
        }

        return points;
    }

    public override void ListGoal()
    {
        string statusSymbol = IsComplete() ? "X" : " ";
        
        Console.Write($"[{statusSymbol}] {_shortName} ({_description}) -- Currently Completed {_amountCompleted}/{_target}");
    }

    public override string SaveGoal()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_bonusPoints},{_target},{_amountCompleted}";
    }
}
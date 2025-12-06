using System;

public abstract class Exercise
{
    protected string _date;
    protected int _minutes;
    protected string _name;

    public Exercise(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();

    public string GetSummary()
    {
    
        string summary = $"{_date} {_name} ({_minutes} min)- Distance {CalculateDistance():F1} km, Speed: {CalculateSpeed():F1} kph, Pace: {CalculatePace():F1} min per km";
        return summary;
    }
}
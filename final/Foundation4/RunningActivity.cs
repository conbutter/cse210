using System;

class RunningActivity : Activity
{
    // Attribute declaration
    private double _distance;

    // Constructor declaration
    public RunningActivity(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    // Module declaration
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance * (GetLength() / 60)) * 60;

    }

    public override double GetPace()
    {
        return (GetLength() / 60) / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} | Running ({GetLength()} mins) - Distance {_distance} miles, Speed {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile";
    }
}
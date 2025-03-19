using System;

class SwimmingActivity : Activity
{
    // Attribute declaration
    private double _laps;

    // Constructor declaration
    public SwimmingActivity(string date, int length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    // Module declaration
    public override double GetDistance() 
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed() // (miles per hour or kilometers per hour)
    {
        return ( GetDistance() / GetLength() ) * 60;
    }

    public override double GetPace() // (minutes per mile or minutes per kilometer)
    {
        return GetLength() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} | Swimming ({GetLength()} minutes) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
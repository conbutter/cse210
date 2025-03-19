using System;

class CyclingActivity : Activity
{
    // Attribute declaration
    private double _speed;

    // Constructor declaration
    public CyclingActivity(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    // Module declaration
    public override double GetDistance()
    {
        return _speed / 60;
    }

    public override double GetSpeed() // (miles per hour or kilometers per hour)
    {
        return _speed;
    }

    public override double GetPace() // (minutes per mile or minutes per kilometer)
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} | Swimming ({GetLength()} minutes) - Distance {GetDistance()} miles, Speed {_speed} mph, Pace: {GetPace()} min per mile";
    }
}
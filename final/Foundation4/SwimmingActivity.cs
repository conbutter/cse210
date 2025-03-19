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
        return 0;
    }

    public override double GetSpeed() // (miles per hour or kilometers per hour)
    {
        return 0;
    }

    public override double GetPace() // (minutes per mile or minutes per kilometer)
    {
        return 0;
    }

    public override string GetSummary()
    {
//      A summary in the form of:
//         03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
//         03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
    }
}

// Math Hints:
//     Distance (miles) = swimming laps * 50 / 1000 * 0.62
//     Speed (mph or kph) = (distance / minutes) * 60
//     Pace (min per mile or min per km) = minutes / distance
//     Speed = 60 / pace
//     Pace = 60 / speed
//     In either case the length of a lap in the lap pool is 50 meters.
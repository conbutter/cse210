using System;

class Activity
{
    // Attribute declaration
    private string _date;
    private int _length;

    // Constructor declaration
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    // Module declaration
    public int GetLength()
    {
        return _length;
    }
    
    public string GetDate()
    {
        return _date;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed() // (miles per hour or kilometers per hour)
    {
        return 0;
    }

    public virtual double GetPace() // (minutes per mile or minutes per kilometer)
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} ({_length})";
//      A summary in the form of:
//         03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
//         03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
    }
}

// Math Hints:
//     Distance (miles) = swimming laps * 50 / 1000 * 0.62
//     Speed (mph or kph) = (distance / minutes) * 60
//     Pace (min per mile or min per km)= minutes / distance
//     Speed = 60 / pace
//     Pace = 60 / speed
//     In either case the length of a lap in the lap pool is 50 meters.
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

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} | Activity ({_length} mins)";
    }
}
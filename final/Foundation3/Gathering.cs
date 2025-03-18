using System;

class Gathering : Event
{
    // Attribute declaration
    private string _forecast;

    // Constructor declaration
    public Gathering(string title, string desc, string date, string time, string streetAddress, string city, string state, string country, string forecast) : base(title, desc, date, time, streetAddress, city, state, country)
    {
        _forecast = forecast;
    }

    // Module declaration
    public override void DisplayAdditional()
    {
        Console.WriteLine($"Anticipated Weather: {_forecast}");
    }
}
using System;

class Gathering : Event
{
    // Attribute declaration
    private string _forecast;

    // Constructor declaration
    public Gathering(string title, string desc, DateTime date, DateTime time, Address address, string forecast) : base(title, desc, date, time, address)
    {
        _forecast = forecast;
    }

    // Module declaration
    public void DisplayAdditional()
    {
        Console.WriteLine($"Anticipated Weather: {_forecast}");
    }
}
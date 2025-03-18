using System;

class Lecture : Event
{
    // Attribute declaration
    private string _speaker;
    private int _capacity;

    // Constructor declaration
    public Lecture(string title, string desc, string date, string time, string streetAddress, string city, string state, string country, string speaker, int capacity) : base(title, desc, date, time, streetAddress, city, state, country)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Module declaration
    public override void DisplayAdditional()
    {
        Console.WriteLine($"Speaker: {_speaker} | Capacity {_capacity}");
    }
}
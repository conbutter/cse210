using System;

class Reception : Event
{
    // Attribute declaration
    private string _rsvpEmail;

    // Constructor declaration
    public Reception(string title, string desc, string date, string time, string streetAddress, string city, string state, string country, string rsvpEmail) : base(title, desc, date, time, streetAddress, city, state, country)
    {
        _rsvpEmail = rsvpEmail;
    }

    // Module declaration
    public override void DisplayAdditional()
    {
        Console.WriteLine($"RSVP Required, Contact Email: {_rsvpEmail}");
    }
}
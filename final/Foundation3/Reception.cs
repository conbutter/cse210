using System;

class Reception : Event
{
    // Attribute declaration
    private string _rsvpEmail;

    // Constructor declaration
    public Reception(string title, string desc, string date, string time, Address address, string rsvpEmail) : base(title, desc, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // Module declaration
    public override void DisplayAdditional()
    {
        Console.WriteLine($"RSVP Required, Contact Email: {_rsvpEmail}");
    }
}
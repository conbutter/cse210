using System;

class Reception : Event
{
    // Attribute declaration
    private string _rsvpEmail;

    // Constructor declaration
    public Reception(string title, string desc, DateTime date, DateTime time, Address address, string rsvpEmail) : base(title, desc, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // Module declaration
    public void DisplayAdditional()
    {
        Console.WriteLine($"RSVP Required, Contact Email: {_rsvpEmail}");
    }
}
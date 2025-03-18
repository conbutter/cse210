using System;

class Event
{
    // Attribute declaration
    private string _title;
    private string _desc;
    private DateTime _date;
    private DateTime _time;
    private Address _address;

    // Constructor declaration
    public Event(string title, string desc, DateTime date, DateTime time, Address address)
    {
        _title = title;
        _desc = desc;
        this._date = date;
        this._time = time;
        _address = address;
    }

    // Module declaration
    public void DisplayStandard()
    {
        Console.WriteLine($"{_title}\n- {_desc}\n{_date} @ {_time} @ {_address.GetAddress()}");
    }

    public void DisplayFull()
    {
        //  Full details - Lists all of the above  (title, description, date, time, and address)
        //                 plus type of event and information specific to that event type.
        //                 For lectures, this includes the speaker name and capacity.
        //                 For receptions this includes an email for RSVP.
        //                 For outdoor gatherings, this includes a statement of the weather.
    }

    public void DisplayShort()
    {
        // Short description - Lists the type of event, title, and the date.
    }
}
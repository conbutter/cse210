using System;

abstract class Event
{
    // Attribute declaration
    private string _title;
    private string _desc;
    private string _date;
    private string _time;
    private Address _address;

    // Constructor declaration
    public Event(string title, string desc, string date, string time, string streetAddress, string city, string state, string country)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        Address address = new Address(streetAddress, city, state, country);
        _address = address;
    }

    // Module declaration
    public void DisplayStandard()
    {
        Console.WriteLine($"{_title}\n{_desc}\n{_date}, {_time} @ {_address.GetAddress()}");
    }

    public void DisplayFull()
    {
        string eventType = GetEventType();
        Console.WriteLine($"{_title}\n{_desc}\nUpcoming {eventType} | {_date}, {_time}\n{_address.GetAddress()}");
        if ( (eventType == "Lecture") || (eventType == "Reception") || ( eventType == "Gathering" ))
        {
            this.DisplayAdditional();
        }
    }

    public abstract void DisplayAdditional();

    public void DisplayShort()
    {
        string eventType = GetEventType();
        Console.WriteLine($"{_title} | {eventType} on {_date}");
    }

    public string GetEventType()
    {
        string eventType = "Event";

        if (this is Lecture)
        {
            eventType = "Lecture";
        } else if (this is Reception)
        {
            eventType = "Reception";
        } else if (this is Gathering)
        {
            eventType = "Gathering";
        }

        return eventType;
    }
}
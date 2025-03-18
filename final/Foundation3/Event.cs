using System;

class Event
{
    // Attribute declaration
    private string _title;
    private string _desc;
    private DateTime date;
    private DateTime time;
    private string address;

    // Constructor declaration

    // Module declaration
    public void DisplayStandard()
    {
        // Standard details - Lists the title, description, date, time, and address.
    }

    public void DisplayFull()
    {
        //  Full details - Lists all of the above, plus type of event and information
        //                 specific to that event type.
        //                 For lectures, this includes the speaker name and capacity.
        //                 For receptions this includes an email for RSVP.
        //                 For outdoor gatherings, this includes a statement of the weather.
    }

    public void DisplayShort()
    {
        // Short description - Lists the type of event, title, and the date.
    }
}
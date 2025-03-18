using System;

class Lecture : Event
{
    // Attribute declaration
    private string _speaker;
    private int _capacity;

    // Constructor declaration
    public Lecture(string title, string desc, DateTime date, DateTime time, Address address, string speaker, int capacity) : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Module declaration
    // [!] No additional modules to declare!
}
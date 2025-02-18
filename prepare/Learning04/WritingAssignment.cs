using System;

class WritingAssignment : Assignment
{
    // Attribute declaration
    private string _title;

    // Constructor declaration

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    // Module declaration
    public void GetWritingInformation()
    {
        Console.WriteLine($"{_title} by {GetStudentName()}");
    }
}
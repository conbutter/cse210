using System;

class Assignment
{
    // Attribute declaration
    private string _studentName;
    private string _topic;

    // Constructor declaration

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    // Module declaration
    public void GetSummary()
    {
        Console.WriteLine($"{_studentName} - {_topic}");
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}
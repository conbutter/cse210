using System;

class MathAssignment : Assignment
{
    // Attribute declaration
    private string _textbookSection;
    private string _problems;

    // Constructor declaration

    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Module declaration
    public void GetHomeworkList()
    {
        Console.WriteLine($"Section {_textbookSection}, Problems {_problems}");
    }
}
using System;

class Comment
{
    // Attribute declaration
    private string _author;
    private string _content;

    // Constructor declaration
    public Comment(string author, string content)
    {
        _author = author;
        _content = content;
    }

    // Module declaration
    public void Display()
    {
        Console.WriteLine($"{_author}: {_content}");
    }
}
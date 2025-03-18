using System;
using System.ComponentModel.DataAnnotations;

class Video
{
    // Attribute declaration
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    // Constructor declaration
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Module declaration
    public void Display()
    {
        Console.WriteLine($"\n{_title} | by {_author} | {_length} seconds\nComments:");
        foreach ( Comment comment in _comments )
        {
            comment.Display();
        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}
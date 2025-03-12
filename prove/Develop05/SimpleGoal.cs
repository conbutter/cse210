using System;
using System.Runtime.CompilerServices;

class SimpleGoal : Goal
{
    // Attribute declaration
    private bool _isCompleted;

    // Constructor declaration
    public SimpleGoal(string name, string description, bool isCompleted, int points) : base(name, description, points)
    {
        _isCompleted = isCompleted;
    }

    // Module declaration
    public override bool IsCompleted()
    {
        return _isCompleted;
    }

    public override void SetCompleted()
    {
        _isCompleted = true;
    }

    public override void DisplayGoal()
    {
        if ( _isCompleted == true ) {
            Console.WriteLine($"[X] {_name} ({_description}) - {_points} points");
        } else {
            Console.WriteLine($"[ ] {_name} ({_description}) - {_points} points");
        }
    }
}
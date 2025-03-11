using System;

class EternalGoal : Goal
{
    // No attributes to declare

    // Constructor declaration
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // No additional constructor information
    }

    // Module declaration
    public override bool isCompleted()
    {
        return false;
    }

    public override void setCompleted()
    {
        // No functionality
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[E] {_name} ({_description}) - {_points} points");
    }
}
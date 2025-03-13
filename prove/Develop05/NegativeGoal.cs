using System;

class NegativeGoal : Goal
{
    // No attributes to declare

    // Constructor declaration
    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
        // No additional constructor information
    }

    // Module declaration
    public override bool IsCompleted()
    {
        return false;
    }

    public override void SetCompleted()
    {
        // No functionality; this goal cannot be set to completed, so this function performs nothing
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[-] {_name} ({_description}) - {_points} point deduction per event");
    }
}
using System;
using System.Runtime.CompilerServices;

abstract class Goal
{
    // Attribute declaration
    protected string _name;
    protected string _description;
    protected int _points;

    // Constructor declaration
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Module declaration
    public abstract bool IsCompleted();

    public abstract void SetCompleted();

    public abstract void DisplayGoal();

    public string GetName()
    {
        return _name;
    }

       public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }
}
using System;
using System.Reflection.Metadata.Ecma335;

class ChecklistGoal : Goal
{
    // Attribute declaration
    private bool _isCompleted = false;
    private int _numberToComplete;
    private int _completedSoFar;
    private int _finishPoints;

    // Constructor declaration
    public ChecklistGoal(string name, string description, bool isCompleted, int points, int numberToComplete, int finishPoints) : base(name, description, points)
    {
        _isCompleted = isCompleted;
        _numberToComplete = numberToComplete;
        _completedSoFar = 0;
        _finishPoints = finishPoints;
    }

    // Module declaration
    public override bool IsCompleted()
    {
        return _isCompleted;
    }

    public override void SetCompleted()
    {
        _completedSoFar += 1;
        if ( _completedSoFar >= _numberToComplete ) {
            _isCompleted = true;
        }
    }

    public int GetFinishPoints()
    {
        return _finishPoints;
    }

    public int GetCompletedSoFar()
    {
        return _completedSoFar;
    }

    public int GetNumberToComplete()
    {
        return _numberToComplete;
    }

    public override void DisplayGoal()
    {
        if ( _isCompleted == true ) {
            Console.WriteLine($"[X] ({_completedSoFar}/{_numberToComplete}) {_name} ({_description}) - {_points} points per step - {_finishPoints} bonus");
        } else {
            Console.WriteLine($"[ ] ({_completedSoFar}/{_numberToComplete}) {_name} ({_description}) - {_points} points per step - {_finishPoints} bonus");
        }
    }
}
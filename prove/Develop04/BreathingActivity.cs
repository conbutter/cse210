using System;
using System.ComponentModel;

class BreathingActivity : Activity
{
    // No included attributes

    // Constructor declaration

    public BreathingActivity(string name, string desc) : base(name, desc)
    {
        // No further elements
    }

    // Module declaration

    public void DoActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < finishTime)
        {
            ShowCountDown("\nBreathe in... ", 4);
            ShowCountDown("Breathe out... ", 6);
            Console.WriteLine();
        }
    }
}
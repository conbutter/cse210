using System;

class Activity
{
    // Attribute declaration
    string _name;
    string _desc;
    int _duration;

    // Constructor declaration

    public Activity()
    {
        _name = "";
        _desc = "";
        _duration = 0;
    }

    public Activity(string name, string desc, int duration)
    {
        _name = name;
        _desc = desc;
        _duration = duration;
    }

    // Module declaration

    public void DisplayIntro()
    {
        // Display intro based on video concept
    }

    public void PromptDuration()
    {
        // Returns duration of activity prompt
    }

    public void ShowGetReady()
    {
        // Display prep text based on video concept
    }

    public void ShowAnimation(int length)
    {
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(length);

        while (DateTime.Now < finishTime)
        {
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(string text, int length)
    {
        // Show countdown animation with provided text and length
    }

    public void DisplayWellDone()
    {
        // Display well done text, using information about activity name and details
    }
}
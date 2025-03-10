using System;
using System.Diagnostics.Metrics;

class Activity
{
    // Attribute declaration
    private string _name;
    private string _desc;
    private int _duration;

    // Constructor declaration

    public Activity(string name, string desc)
    {
        _name = name;
        _desc = desc;
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
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!\n\n{_desc}\n");
    }

    public void PromptDuration()
    {
        bool validInput = false;

        while (validInput == false)
        {
            Console.WriteLine("How long, in seconds, do you want the session to be? ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int duration))
            {
                if (duration > 0)
                {
                    _duration = duration;
                    validInput = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("[!] Please enter a duration greater than zero.\n");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("[!] Invalid input. Please enter a whole number.\n");
            }
        }
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void ShowGetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready to start...");
        ShowAnimation(5);
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
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
        int counterNumber = length;
        Console.Write(text);

        while (counterNumber != 0)
        {
            Console.Write(counterNumber);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            counterNumber -= 1;
        }
    }

    public void DisplayWellDone()
    {
        Console.WriteLine("\n--- End of Activity ---\nWell done!");
        ShowAnimation(3);
        Console.WriteLine($"You completed {_duration} seconds of the {_name} Activity.");
        ShowAnimation(5);
        Console.Clear();
    }
}
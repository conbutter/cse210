using System;
using System.ComponentModel;

class Log
{
    // Attribute declaration
    private int _activityCounter = 0;
    private int _breathingCounter = 0;
    private int _reflectionCounter = 0;
    private int _listingCounter = 0;
    private int _secondsSpentInActivity = 0;

    // No constructors necessary

    // Module declaration

    public void AddToCounter(int activityType, int secondsSpent)
    {
        _activityCounter += 1;
        _secondsSpentInActivity += secondsSpent;

        if ( activityType == 0 )
        {
            _breathingCounter += 1;
        } else if ( activityType == 1)
        {
            _reflectionCounter += 1;
        } else if ( activityType == 2)
        {
            _listingCounter += 1;
        }

    }

    public void DisplayLog()
    {
        Console.Clear();
        Console.WriteLine($"--- Activity Log ---\n");
        
        // Display total activities counter
        if ( _activityCounter != 0 )
        {
            Console.WriteLine($"Total activities completed: {_activityCounter}\n");
        } else {
            Console.WriteLine($"You haven't completed any activities yet!\n");
        }

        // Display breathing activities counter
        if ( _breathingCounter != 0 )
        {
            Console.WriteLine($"Breathing activites completed: {_breathingCounter}");
        } else {
            Console.WriteLine($"You haven't completed a breathing activity yet!");
        }

        // Display reflection activities counter
        if ( _reflectionCounter != 0 )
        {
            Console.WriteLine($"Reflection activites completed: {_reflectionCounter}");
        } else {
            Console.WriteLine($"You haven't completed a reflection activity yet!");
        }

        // Display listing activities counter
        if ( _listingCounter != 0 )
        {
            Console.WriteLine($"Listing activites completed: {_listingCounter}\n");
        } else {
            Console.WriteLine($"You haven't completed a listing activity yet!\n");
        }

        // Display total time spent
        if ( _secondsSpentInActivity != 0 )
        {   
            if ( _secondsSpentInActivity == 1 )
            {
                Console.WriteLine($"Total time spent in activities: {_secondsSpentInActivity} second\n");
            } else {
                Console.WriteLine($"Total time spent in activities: {_secondsSpentInActivity} seconds\n");
            }
        } else {
            Console.WriteLine($"No time has been spent in activities.\n");
        }  

        // Await user input to return to menu
        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
        Console.Clear();
    }
}
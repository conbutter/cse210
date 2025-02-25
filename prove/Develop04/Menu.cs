using System;

class Menu
{
    // Attribute declaration
    string _menuContents;
    bool _menuRunning;

    // Constructor declaration

    public Menu()
    {
        _menuContents = "Activity Program Menu\n 1. Begin breathing activity\n 2. Begin reflection activity\n 3. Begin listing activity\n 4. Quit program\nPlease type the number of the option you wish to select. ";
        _menuRunning = false;
    }

    // Module declaration
    
    public void StartMenuLoop()
    {
        _menuRunning = true;
        while ( _menuRunning == true )
        {
            DisplayMenu();
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "Throughout this exercise, we'll walk you through breathing in and out. Let your mind relax, and focus on your breathing.");
                breathingActivity.DisplayIntro();
                breathingActivity.PromptDuration();
                breathingActivity.ShowGetReady();
                breathingActivity.DoActivity();
                breathingActivity.DisplayWellDone();
            } else if (userInput == "2")
            {
                // Start reflection activity
            } else if (userInput == "3")
            {
                // Start listing activity
            } else if (userInput == "4")
            {
                _menuRunning = false;
                Console.WriteLine("Quitting program...");
            } else
            {
                Console.Clear();
                Console.WriteLine("[!] That is not an acceptable response. Please choose from the list of options below.\n");
            }
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine(_menuContents);
    }
}
using System;

class Menu
{
    // Attribute declaration
    string _menuContents;
    bool _menuRunning;

    // Constructor declaration

    public Menu()
    {
        _menuContents = "Menu here";
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
            if (userInput == "q")
            {
                _menuRunning = false;
                Console.WriteLine("Goodbye!");
            }
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine(_menuContents);
    }
}
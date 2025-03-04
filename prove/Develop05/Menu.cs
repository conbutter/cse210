using System;

class Menu
{
    private string _menuContents;

    // Constructor declaration

    public Menu()
    {
        _menuContents = "-+- Goal Tracker Menu -+-\n 1. Create new goal\n 2. List all goals\n 3. Save goals\n 4. Load goals\n 5. Record event\n 6. Quit program\nPlease type the number of the option you wish to select. ";
    }

    // Module declaration

    public void DisplayMenu()
    {
        Console.WriteLine(_menuContents);
    }
}
using System;

class Menu
{
    // Attribute declaration
    private string _menuContents;

    // Constructor declaration

    public Menu()
    {
        _menuContents = "Activity Program Menu\n 1. Begin breathing activity\n 2. Begin reflection activity\n 3. Begin listing activity\n 4. Open activity log\n 5. Quit program\nPlease type the number of the option you wish to select. ";
    }

    // Module declaration

    public void DisplayMenu()
    {
        Console.WriteLine(_menuContents);
    }
}
using System;

class Menu
{
    // Attribute declaration
    string _menuContents;

    // Constructor declaration

    public Menu()
    {
        _menuContents = "Menu here";
    }

    // Module declaration
    
    public void DisplayMenu()
    {
        Console.WriteLine(_menuContents);
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu();
        mainMenu.StartMenuLoop();

        Activity testActivity = new Activity();
        testActivity.ShowAnimation(5);
    }
}
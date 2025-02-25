using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Create class objects & variables
        Menu mainMenu = new Menu();
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "Throughout this exercise, we'll walk you through breathing in and out. Let your mind relax, and focus on your breathing.");
        bool programRunning = true;

        // Main program loop
        while ( programRunning == true )
        {
            mainMenu.DisplayMenu();
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                breathingActivity.DisplayIntro();
                breathingActivity.PromptDuration();
                breathingActivity.ShowGetReady();
                breathingActivity.DoActivity();
                breathingActivity.DisplayWellDone();
            }
            else if (userInput == "2")
            {
                // Start reflection activity
            }
            else if (userInput == "3")
            {
                // Start listing activity
            }
            else if (userInput == "4")
            {
                programRunning = false;
                Console.WriteLine("Quitting program...");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("[!] That is not an acceptable response. Please choose from the list of options below.\n");
            }
        }
    }
}
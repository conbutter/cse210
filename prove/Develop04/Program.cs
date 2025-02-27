using System;

class Program
{
    private int _activityCounter;
    private int _breathingCounter = 0;
    private int _reflectionCounter = 0;
    private int _listingCounter = 0;

    static void Main(string[] args)
    {
        Console.Clear();

        // Create class objects & variables
        Menu mainMenu = new Menu();
        BreathingActivity breathingActivity = new BreathingActivity(
            "Breathing", 
            "Throughout this exercise, we'll walk you through breathing in and out. Let your mind relax, and focus on your breathing."
            );
        ReflectionActivity reflectionActivity = new ReflectionActivity(
            "Reflection", 
            "Throughout this exercise, you'll be asked to remember certain times in your life. These should optimally be instances where you have shown strength, resilience, and power."
            );
        ListingActivity listingActivity = new ListingActivity(
            "Listing", 
            "Throughout this exercise, you'll be given a general prompt and asked to list as many good things relating to it as you can."
            );
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
                reflectionActivity.DisplayIntro();
                reflectionActivity.PromptDuration();
                reflectionActivity.ShowGetReady();
                reflectionActivity.DoActivity();
                reflectionActivity.DisplayWellDone();
            }
            else if (userInput == "3")
            {
                listingActivity.DisplayIntro();
                listingActivity.PromptDuration();
                listingActivity.ShowGetReady();
                listingActivity.DoActivity();
                listingActivity.DisplayWellDone();
            }
            else if (userInput == "4")
            {
                Console.Clear();
                Console.WriteLine("[!] Activity Log coming soon!\n");
            }
            else if (userInput == "5")
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
using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Welcome, Load / Save
        Console.WriteLine("Welcome to the Journal Program!");

        Journal myJournal = new Journal();
        AddEntry();
        
    }

    public static void AddEntry() 
    {
        PromptManager promptManager = new PromptManager;
        Entry newEntry = new Entry();
        newEntry._date = DateTime.Today.ToString(); // Add date
        newEntry._prompt = PromptManager.GetRandomPrompt();
    }

}
using System;
using System.Net.Quic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Create objects
        PromptManager _promptManager = new PromptManager();
        Menu _menu = new Menu();
        Journal _journal = new Journal();

        // Welcome + Program Loop
        Console.WriteLine("Welcome to the Journal Program!");

        bool program_active = true;

        while ( program_active == true ) {
            Menu.DisplayMenu();
            string user_response = Console.ReadLine();
            int selected_item = Int32.Parse( user_response );
            if ( selected_item == 1 ){ // Add Entry
                AddEntry(_promptManager, _journal);
            } else if ( selected_item == 2 ) { // Display All Entries
                DisplayJournal(_journal);
            } else if ( selected_item == 3 ) { // Coming Soon
                Console.WriteLine("Coming soon!");
            } else if ( selected_item == 4 ) { // Quit Program
                Quit();
            } else {
                Console.WriteLine("That is not an acceptable option.");
            }
            
        }

        
        
    }

    public static void AddEntry(PromptManager _promptManager, Journal _journal) 
    {
        Entry newEntry = new Entry();
        newEntry._date = DateTime.Now.ToString("yyyy-MM-dd"); // Add date
        newEntry._prompt = _promptManager.GetRandomPrompt(); // Get prompt
        Console.WriteLine($"Please answer the prompt: {newEntry._prompt}"); // Obtain Response
        newEntry._response = Console.ReadLine(); // Save response
        _journal._entries.Add(newEntry); // Save as entry to currently loaded Journal
    }

    public static void DisplayJournal(Journal _journal)
    {
        foreach ( var entry in _journal._entries )
        {
            Console.WriteLine($"{entry._date} | Prompt: {entry._prompt} | Response: {entry._response}");
        }
    }

    public static void Quit()
    {
        Console.WriteLine("Quitting program...");
        Environment.Exit(0);
    }
}
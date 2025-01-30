using System;
using System.Net.Quic;
using System.Runtime.InteropServices;
using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;


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

        StartingLoadHandler(); // Initial Program Load / Save Handler Function

        bool program_active = true;

        while ( program_active == true ) {
            Menu.DisplayMenu();
            string user_response = Console.ReadLine();
            int selected_item = Int32.Parse( user_response );
            if ( selected_item == 1 ){ // Add Entry
                AddEntry(_promptManager, _journal);
            } else if ( selected_item == 2 ) { // Display All Entries
                DisplayJournal(_journal);
            } else if ( selected_item == 3 ) { // Load / Save Handler
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

    public static void StartingLoadHandler()
    {
        Console.WriteLine("\nWould you like to create a new journal or load a previous one?\n1) Create New Journal\n2) Load Journal\n\nPlease type the number of the option you wish to select.");
        string user_response = Console.ReadLine();
        int selected_item = Int32.Parse( user_response );
        Journal _journal = new Journal();
        if ( selected_item == 1 ) {
            Console.WriteLine("New journal created. Please specify journal file name. DO NOT include '.json'.");
            string filename = Console.ReadLine();
            Console.WriteLine($"New Journal named '{filename}' created.");
            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{filename}.json");
            _journal.SaveToFile(filepath);
            return;
        } else if ( selected_item == 2 ) {
            LoadNewJournal();
        }
    }

    public static void LoadNewJournal() {
        Console.WriteLine("Please type the filename of the journal you wish to load. DO NOT include '.json'.");
        string filename = Console.ReadLine();
        string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{filename}.json");
        Journal.LoadFromFile(filepath);
        return;
    }

    public static void SaveNewJournal() {
        Console.WriteLine("Please type the filename of the journal you wish to save. DO NOT include '.json'.");
        string filename = Console.ReadLine();
        string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{filename}.json");
        Console.WriteLine($"Saving journal as '{filename}.json'...");
        _journal.SaveToFile(filepath);

    }
}
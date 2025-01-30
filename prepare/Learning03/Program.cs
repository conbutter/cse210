using System;
using System.IO;

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
        bool edit_status = false;

        while ( program_active == true ) {
            Menu.DisplayMenu();
            string user_response = Console.ReadLine();
            if ( user_response == "1" ){ // Add Entry
                AddEntry(_promptManager, _journal);
                edit_status = true;
            } else if ( user_response == "2" ) { // Display All Entries
                DisplayJournal(_journal);
            } else if ( user_response == "3" ) { // Save Journal
                SaveJournal(_journal);
                edit_status = false;
            } else if ( user_response == "4" ) { // Load Journal
                VerifySavePrompt(_journal, edit_status, "loading another journal");
                LoadJournal(_journal);
            } else if ( user_response == "5" ) { // Quit Program
                VerifySavePrompt(_journal, edit_status, "quitting the program");
                Quit();
            } else {
                Console.WriteLine("\nThat is not an acceptable option. Please enter an acceptable integer.");
            }
            
        }
        
    }

    public static void AddEntry(PromptManager _promptManager, Journal _journal) 
    {
        Entry newEntry = new Entry();
        newEntry._date = DateTime.Now.ToString("yyyy-MM-dd"); // Add date
        newEntry._prompt = _promptManager.GetRandomPrompt(); // Get prompt
        Console.WriteLine($"\nPlease answer the prompt: {newEntry._prompt}"); // Obtain Response
        newEntry._response = Console.ReadLine(); // Save response
        _journal._entries.Add(newEntry); // Save as entry to currently loaded Journal
        Console.WriteLine($"New entry added: '{newEntry._prompt} | {newEntry._response}");
    }

    public static void DisplayJournal(Journal _journal)
    {
        if ( _journal._entries.Count() != 0 ) {
            Console.WriteLine("\n");
            foreach ( var entry in _journal._entries )
            {
                Console.WriteLine($"{entry._date} | Prompt: {entry._prompt} | Response: {entry._response}");
            }
        } else {
            Console.WriteLine($"\nYour journal currently has no entries. Why not try adding one?");
        }
        
    }

    public static void SaveJournal(Journal _journal) {
        if ( _journal._entries.Count() != 0 ) {
            Console.WriteLine("\nPlease type a filename to save the journal to (include file type).");
            string filename = Console.ReadLine();
            Console.WriteLine($"Saving journal '{filename}'...");
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach ( var entry in _journal._entries )
                {
                    outputFile.WriteLine($"{entry._date}%{entry._prompt}%{entry._response}");
                }
            }
            Console.WriteLine($"Journal '{filename}' saved.");
        } else {
            Console.WriteLine($"\nYour journal currently has no entries. To save, please add at least 1 entry.");
        }
    }

    public static void LoadJournal(Journal _journal) {
        Console.WriteLine("\nPlease type the filename of the journal you wish to load (include file type).");
        string filename = Console.ReadLine();
        Console.WriteLine($"Loading journal '{filename}'...");
        _journal._entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("%");

            string _entryDate = parts[0];
            string _entryPrompt = parts[1];
            string _entryResponse = parts[2];

            AddEntryViaLoad(_journal, _entryDate, _entryPrompt, _entryResponse);
        }
        Console.WriteLine($"\nJournal '{filename}' loaded.");
    }

    public static void AddEntryViaLoad(Journal _journal, string date, string prompt, string response) 
    {
        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._prompt = prompt;
        newEntry._response = response;
        _journal._entries.Add(newEntry);
    }

    public static void Quit()
    {
        Console.WriteLine("\nQuitting program...");
        Environment.Exit(0);
    }

    public static void VerifySavePrompt(Journal _journal, bool edit_status, string action_type) {
        if ( edit_status == true ) {
            bool verify_prompt_active = true;
            while ( verify_prompt_active == true ) {
                Console.WriteLine($"Would you like to save before {action_type}? (y/n)");
                string user_response = Console.ReadLine();
                if ( user_response == "y" ) {
                    verify_prompt_active = false;
                    SaveJournal(_journal);
                    return;
                } else if ( user_response == "n" ) {
                    verify_prompt_active = false;
                    return;
                } else {
                    Console.WriteLine("\nThat is not an acceptable option. Please type either 'y' or 'n'.");
                }
            }
        } else {
            return;
        }
    }
}
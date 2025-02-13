using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

class Program
{
    // Module Declaration
    static void Main(string[] args)
    {
        ScriptureMan scripture_selector = new ScriptureMan();
        Scripture chosen_scripture = scripture_selector.ChooseRandomScripture();
        Console.Clear();

        bool program_status = true;
        while ( program_status == true )
        {
            chosen_scripture.Display();
            Console.WriteLine("\n\nPress ENTER to continue, or type 'quit' to finish.");
            string user_input = Console.ReadLine();
            if ( user_input.ToLower() == "quit" )
            {
                program_status = false;
            } else {
                if ( chosen_scripture.IsFinished() )
                {
                    Environment.Exit(0);
                }
                chosen_scripture.HideElements();
            }
        }
    }
}
using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

class Program
{
    // Module Declaration
    static void Main(string[] args)
    {
        ScriptureMan _scripture_selector = new ScriptureMan();
        Scripture _chosenscripture = _scripture_selector.ChooseRandomScripture();
        Console.Clear();

        bool program_status = true;
        while ( program_status == true )
        {
            _chosenscripture.Display();
            Console.WriteLine("\n\nPress ENTER to continue, or type 'quit' to finish.");
            string user_input = Console.ReadLine();
            if ( user_input.ToLower() == "quit" )
            {
                program_status = false;
            } else {
                if ( _chosenscripture.IsFinished() )
                {
                    Environment.Exit(0);
                }
                _chosenscripture.HideWords();
            }
        }
    }
}
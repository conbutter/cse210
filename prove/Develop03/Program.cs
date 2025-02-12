using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

class Program
{
    // Attribute Declaration
    private static List<Scripture> _scriptures = new List<Scripture>();

    // Module Declaration
    static void Main(string[] args)
    {
        ScriptureMan scripture_selector = new ScriptureMan();
        Scripture scripture1 = scripture_selector.chooseRandomScripture();
        Console.Clear();

        bool program_status = true;
        while ( program_status == true )
        {
            scripture1.Display();
            Console.WriteLine("\n\nPress ENTER to continue, or type 'quit' to finish.");
            string user_input = Console.ReadLine();
            if ( user_input.ToLower() == "quit" )
            {
                program_status = false;
            } else {
                isFinished(scripture1);
                scripture1.HideWords();
            }
        }
    }

    public static void isFinished(Scripture scripture)
    {
        if ( scripture.isFinished() == true )
        {
            Environment.Exit(0);
        }
    }

}
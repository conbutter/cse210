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
        Scripture scripture1 = new Scripture("Alma 26:26-27", "But behold, my beloved brethren, we came into the wilderness not with the intent to destroy our brethren, but with the intent that perhaps we might save some few of their souls.|Now when our hearts were depressed, and we were about to turn back, behold, the Lord comforted us, and said: Go amongst thy brethren, the Lamanites, and bear with patience thine afflictions, and I will give unto you success.");
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
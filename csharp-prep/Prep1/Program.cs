using System;

class Program
{
    static void Main(string[] args)
    {
        // Obtain name
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        // Return stylized name
        Console.WriteLine();        // Spacer line
        Console.WriteLine($"My name is {lname}, {fname} {lname}.");
    }
}
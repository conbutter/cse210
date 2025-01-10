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

        // Apparently I committed using the wrong account initally, whoops! This comment line is to verify that I switched my Git account correctly so changes will appear under the correct account.
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Buffer line for style
        Console.WriteLine();

        // Variable declaration
        int gradePercentage;
        string userInput;
        string letter = "";
        bool classPassed = false;

        // Obtain percentage
        Console.Write("What is your grade percentage? ");
        userInput = Console.ReadLine();
        gradePercentage = int.Parse(userInput);

        // Determine letter grade
        if ( gradePercentage >= 90 ) 
        {
            letter = "A";
        }
        else if ( gradePercentage >= 80 )
        {
            letter = "B";
        }
        else if ( gradePercentage >= 70 )
        {
            letter = "C";
        }
        else if ( gradePercentage >= 60 )
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine class pass status
        if ( gradePercentage >= 70 )
        {
            classPassed = true;
        }
        else
        {
            classPassed = false;
        }

        // Print letter grade & pass/fail status
        Console.WriteLine($"Your grade is a {letter}.");
        if ( classPassed == true ) {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class. Better luck next time!");
        }

        // Buffer line for style
        Console.WriteLine();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
      
      DisplayWelcome();
      string userName = PromptUserName();
      float userNumber = PromptUserNumber();
      float squaredNumber = SquareNumber(userNumber);
      DisplayResult(userName, squaredNumber);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userInput = Console.ReadLine();
        return userInput;
    }

    static float PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        return float.Parse(userInput);
    }

    static float SquareNumber(float unsquaredNumber)
    {
        float squaredNumber = unsquaredNumber * unsquaredNumber;
        return squaredNumber;
    }

    static void DisplayResult(string inputName, float squaredNumber)
    {
        Console.WriteLine($"{inputName}, the square of your number is {squaredNumber}");
    }
}
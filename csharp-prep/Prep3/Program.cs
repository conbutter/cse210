using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        int magicNumber;
        int userGuess;
        bool numberGuessed = false;
        int guessCount = 0;

        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 100);

        // UNUSED CODE - Get the number from the user instead
        // Console.Write("What is the magic number? ");
        // userInput = Console.ReadLine();
        // magicNumber = int.Parse(userInput);

        do
        {
            Console.Write("What is your guess? ");
            userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);
            guessCount += 1;

            if ( userGuess != magicNumber ) {
                if ( userGuess > magicNumber ) {
                    Console.WriteLine("Lower");
                } else if ( userGuess < magicNumber ) {
                    Console.WriteLine("Higher");
                }
            } else {
                numberGuessed = true;
                if ( guessCount != 1 ) {
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                } else {
                    Console.WriteLine($"You guessed it! It took you {guessCount} guess.");
                }
            }
        } while ( numberGuessed != true );

    }
}
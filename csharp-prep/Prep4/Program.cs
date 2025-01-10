using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        bool dataGatherStatus = true;

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while ( dataGatherStatus != false )
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            if ( int.Parse(userInput) == 0 )
            {
                dataGatherStatus = false;
            } else {
                numbers.Add(int.Parse(userInput));
            }
        }

        // Sum calculation & print
        int numberSum = 0;
        foreach (int number in numbers)
        {
            numberSum += number;
        }
        Console.WriteLine($"The sum is: {numberSum}");

        // Average calculation & print
        float numberAverage = (float)numberSum / numbers.Count;
        Console.WriteLine($"The average is: {numberAverage}");

        // Largest calculation & print
        int numberLargest = 0;
        foreach (int number in numbers )
        {
            if ( number > numberLargest )
            {
                numberLargest = number;
            }
        }
        Console.WriteLine($"The largest number is: {numberLargest}");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Variable declaration
        int x = 9;                      // 4 byte
        uint z = 351;                   // 4 byte, can only be positive
        long y = 91;                    // 8 byte
        float gpa = 3.8976F;            // 4 byte, 7-8 significant digits
        double randomnum = 3.31531;     // 8 byte, 17 significant digits
        string name = "test";           // string (obvious)
        bool tired = true;              // true or false

        // Print to console
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine(tired);
        Console.Write("gpa");

        // If/then statement
        if (x == 9) {
            Console.WriteLine("X is equal to 9.");}
        else {
            Console.WriteLine("X is NOT equal to 9.");
        }

        // For loops
        for (int i = 0; i < 100; i++) {
            System.Console.WriteLine(i);
        }

        int j = 0;
        for (; j < 100; j += 10) {
            System.Console.WriteLine(j);
        }

        // Add and remove
        x++;
        Console.WriteLine(x);
        x--;
        Console.WriteLine(x);
        ++x;
        Console.WriteLine(x);
        --x;
        Console.WriteLine(x);

        // User input
        string fname = "";
        Console.Write("Enter first name: ");
        fname = Console.ReadLine();      // Cannot add arguments to this input

        // String formatting
        Console.WriteLine($"My name is {fname}");   //$ is equivalent to "f" format from Python

        // AND, OR, and NOT
        // &&, ||, !
        int a = 9;
        int b = 10;
        if (a < 10 && b < 10) {
            Console.WriteLine("Yay");
        } else {
            Console.WriteLine("Nay");
        }

    }
}
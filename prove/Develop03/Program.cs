using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

class Program
{
    // Attribute Declaration
    private List<Scripture> _scriptures = new List<Scripture>();

    // Module Declaration
    static void Main(string[] args)
    {
        Word _testWord = new Word();

        _testWord.SetWord("testing");
        _testWord.Display();
        _testWord.HideWord();
        _testWord.Display();
    }

    public void isFinished()
    {
        // Get scripture, run isFinished() function
    }

    public void HideWords()
    {

    }

    // Keep in mind [ Console.Clear(); ]
}
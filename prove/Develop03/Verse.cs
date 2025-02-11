using System.Runtime.InteropServices;

class Verse
{
    // Attribute Declaration
    private List<Word> _words = new List<Word>();

    // Constructor Declaration
    public Verse()
    {
        // Constructor???
    }

    // Module Declaration
    public void Display()
    {
        foreach (Word _word in _words)
        {
            _word.Display();
        }
    }

    public void HideWords()
    {
        // Obtain list length
        // Choose three random indexes
        // Run HideWord function for each of those words
    }

    public void isFinished()
    {
        // Check each word in list
        // If all of them return hidden, return true
        // Else, return false
    }

}
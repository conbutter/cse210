class Scripture
{
    // Attribute Declaration
    private List<Verse> _verses = new List<Verse>();

    private string _reference; // ADD REFERENCE

    // Constructor Declaration
    public Scripture(string reference, string content)
    {
        _reference = reference;
        string[] verseList = content.Split(";");
        foreach (string verse in verseList)
        {
            _verses.Add(new Verse(verse.Trim()));
        }
    }

    // Module Declaration
    public void Display()
    {
        Console.Clear();
        Console.Write(_reference + " ");
        foreach ( Verse verse in _verses )
        {
            verse.Display();
        }
    }

    public bool isFinished()
    {
        bool finishStatus = true;
        foreach ( Verse verse in _verses )
        {
            if ( verse.isFinished() == false )
            {
                finishStatus = false;
            }
        }
        return finishStatus;
    }

    public void HideWords()
    {
        foreach (Verse verse in _verses)
        {
            verse.HideWords();
        }
        // For each verse in list, hide words
        // Temp code below
    }
}
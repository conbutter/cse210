class Scripture
{
    // Attribute Declaration
    private List<Verse> _verses = new List<Verse>();
    private string _reference;

    // Constructor Declaration
    public Scripture(string reference, string content)
    {
        _reference = reference;
        string[] verseList = content.Split("|");
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
            Console.Write(" ");
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
    List<Word> allWords = new List<Word>();
    foreach (Verse verse in _verses)
    {
        allWords.AddRange(verse.GetWords());
    }

    Random random = new Random();
    int visibleWords = allWords.Count(word => !word.isHidden());
    int wordsToHide = Math.Min(3, visibleWords);

    for (int i = 0; i < wordsToHide;)
    {
        int hideIndex = random.Next(0, allWords.Count);
        if (!allWords[hideIndex].isHidden())
        {
            allWords[hideIndex].HideWord();
            i++;
        }
    }
}
}
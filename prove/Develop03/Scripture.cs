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
    List<Word> all_words = new List<Word>();
    foreach (Verse verse in _verses)
    {
        all_words.AddRange(verse.GetWords());
    }

    Random random = new Random();
    int visible_words = all_words.Count(word => !word.isHidden());
    int words_to_hide = Math.Min(3, visible_words);

    for (int i = 0; i < words_to_hide;)
    {
        int hide_index = random.Next(0, all_words.Count);
        if (!all_words[hide_index].isHidden())
        {
            all_words[hide_index].HideWord();
            i++;
        }
    }
}
}
class Scripture
{
    // Attribute Declaration
    private List<Verse> _verses = new List<Verse>();
    private Reference _reference;

    // Constructor Declaration
    public Scripture( string reference_book, int reference_chapter, int reference_start, int reference_end, string content )
    {
        _reference = new Reference(reference_book, reference_chapter, reference_start, reference_end);
        string[] verseList = content.Split("|");
        foreach ( string verse in verseList )
        {
            _verses.Add(new Verse(verse.Trim()));
        }
    }

    // Module Declaration
    public void Display()
    {
        Console.Clear();
        _reference.Display();
        foreach ( Verse verse in _verses )
        {
            verse.Display();
            Console.Write(" ");
        }
    }

    public bool IsFinished()
    {
        bool finishStatus = true;
        foreach ( Verse verse in _verses )
        {
            if ( verse.IsFinished() == false )
            {
                finishStatus = false;
            }
        }
        return finishStatus;
    }

    public void HideElements()
    {
    List<Word> all_words = new List<Word>();
    foreach ( Verse verse in _verses )
    {
        all_words.AddRange(verse.GetWords());
    }

    Random random = new Random();
    int visible_words = all_words.Count( word => !word.IsHidden() );
    int words_to_hide = Math.Min( 3, visible_words );

    for ( int i = 0; i < words_to_hide; )
    {
        int hide_index = random.Next( 0, all_words.Count );
        if (!all_words[hide_index].IsHidden())
        {
            all_words[hide_index].HideWord();
            i++;
        }
    }
}
}
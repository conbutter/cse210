class Reference
{
    // Attribute Declaration
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    // Constructor Declaration
    public Reference( string book, int chapter, int verse_start, int verse_end )
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse_start;
        _verseEnd = verse_end;
    }

    // Module Declaration
    public void Display()
    {
        Console.Clear();
        Console.Write($"{_book} {_chapter}:");
        if ( _verseStart == _verseEnd )
        {
            Console.Write($"{_verseStart} ");
        } else {
            Console.Write($"{_verseStart}-{_verseEnd} ");
        }
    }
}
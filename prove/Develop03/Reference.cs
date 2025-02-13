class Reference
{
    // Attribute Declaration
    private string _book;
    private int _chapter;
    private int _verse_start;
    private int _verse_end;

    // Constructor Declaration
    public Reference( string book, int chapter, int verse_start, int verse_end )
    {
        _book = book;
        _chapter = chapter;
        _verse_start = verse_start;
        _verse_end = verse_end;
    }

    // Module Declaration
    public void Display()
    {
        Console.Clear();
        Console.Write($"{_book} {_chapter}:");
        if ( _verse_start == _verse_end )
        {
            Console.Write($"{_verse_start} ");
        } else {
            Console.Write($"{_verse_start}-{_verse_end} ");
        }
    }
}
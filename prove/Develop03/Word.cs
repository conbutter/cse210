class Word
{
    // Attribute Declaration
    private string _word;
    private bool _hidden = false;

    // Constructor Declaration
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    // Module Declarations
    public void Display()
    {
        if ( _hidden == true )
        {
            foreach (char letter in _word )
            {
                Console.Write("_");
            }
        } else
            Console.Write(_word);
    }

    public bool IsHidden()
    {
        if ( _hidden == true )
        {
            return true;
        } else 
            return false;
    }

    public void HideWord()
    {
        _hidden = true;
    }
}
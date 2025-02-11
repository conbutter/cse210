using System.ComponentModel.DataAnnotations;

class Word
{
    // Attribute Declaration
    private string _word;
    private bool _hidden = false;

    // Module Declaration
    public void Display()
    {
        if ( _hidden == true )
        {
            foreach (char letter in _word )
            {
                Console.Write("_");
            }
        } else
            Console.WriteLine(_word);
    }

    public bool isHidden()
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

    // TEST ELEMENTS // UNUSED // LEFT FOR TESTING
    public void SetWord(string word)
    {
        _word = word;
    }
}
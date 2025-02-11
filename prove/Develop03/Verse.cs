using System;
using System.Collections.Generic;

class Verse
{
    // Attribute Declaration
    private List<Word> _words = new List<Word>();

    // Constructor Declaration
    public Verse(string content)
    {
        List<string> word_list = new List<string>(content.Split(" "));

        foreach (string word in word_list)
        {
            Word newWord = new Word(word); 
            _words.Add(newWord);
        }
    }

    // Module Declaration
    public void Display()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            _words[i].Display();

            if (i < _words.Count - 1)
            {
                Console.Write(" ");
            }
        }
        Console.Write(" ");
    }

public void HideWords()
{
    int list_length = _words.Count;
    Random random = new Random();
    int visibleWords = _words.Count(word => !word.isHidden());
    int wordsToHide = Math.Min(3, visibleWords);

    for (int i = 0; i < wordsToHide;)
    {
        int hideIndex = random.Next(0, list_length);
        if (!_words[hideIndex].isHidden())
        {
            _words[hideIndex].HideWord();
            i++;
        }
    }
}


    public bool isFinished()
    {
        bool finishStatus = true;
        foreach (Word word in _words)
        {
            if ( word.isHidden() == false )
            {
                finishStatus = false;
            }
        }

        return finishStatus;
    }

}
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
        Console.Write("");
    }

    public void HideWords()
    {
        int list_length = _words.Count();
        Random random = new Random();
        for (int i = 0; i < 3;)
        {
            int hideIndex = random.Next(0, list_length);
            if ( _words[hideIndex].isHidden() == false )
            {
                _words[hideIndex].HideWord();
                i++;
            }
        }
    }

    public List<Word> GetWords()
    {
        return _words;
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
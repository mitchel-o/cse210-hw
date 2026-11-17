using System.Collections.Generic;

public class Scripture
{
    private string _text;
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string text, Reference reference)
    {
        _text = text;
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string text = "";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return _reference.GetDisplayText() + " " + text.Trim();
    }

    public void HideRandomWords(int numberOfWords)
    {
        Random random = new Random();

        for (int i = 0; i < numberOfWords; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
    
}

using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ScriptureMemorizer;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] splitWords = text.Split(' ');
        foreach (string wordtext in splitWords)
        {
            _words.Add(new Word(wordtext));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        if (visibleWords.Count == 0)
        {
            return;
        }

        int wordToHideCount = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < wordToHideCount; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
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

        public string GetDisplayText()
    {
        List<string> wordDisplay = new List<string>();

        foreach (Word word in _words)
        {
            wordDisplay.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()} {string.Join(" ", wordDisplay)}"; 
    }
}
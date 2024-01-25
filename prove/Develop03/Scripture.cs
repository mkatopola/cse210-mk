using System;
using System.Text;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _word;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _word = new List<Word>();

        string[] words = text.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            _word.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(_word.Count);
            Word word = _word[index];
            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        StringBuilder sb = new StringBuilder();

        // Add the book name, chapter, and verse at the beginning
        sb.Append(_reference.GetDisplayText() + " ");

        foreach (Word word in _word)
        {
            if (word.IsHidden())
            {
                for (int i = 0; i < word.GetDisplayText().Length; i++)
                {
                    sb.Append("_");
                }
            }
            else
            {
                sb.Append(word.GetDisplayText());
            }
            sb.Append(" ");
        }
        sb.Length--;
        return sb.ToString();
    }

    public bool IsCompletelyHidden()
    {
        bool allHidden = true;
        foreach (Word word in _word)
        {
            if (!word.IsHidden())
            {
                allHidden = false;
                break;
            }
        }
        return allHidden;
    }
}

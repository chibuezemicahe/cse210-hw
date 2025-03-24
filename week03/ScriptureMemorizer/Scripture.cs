using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;  
    private List<Word> words = new List<Word>();

    
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;  

        string[] splitWords = text.Split(" ");
        foreach (string word in splitWords)
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(words.Count);
        words[randomIndex].Hide();
    }

    public string GetDisplayText()
    {
        string result = "";
        foreach (Word word in words)
        {
            result += word.GetDisplayText() + " ";
        }
        return $"{reference.GetDisplayText()}\n{result.Trim()}";  // Show reference first
    }
}

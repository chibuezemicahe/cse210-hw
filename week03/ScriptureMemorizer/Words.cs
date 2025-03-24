using System;
using System.Collections.Generic;

public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }
    public string GetDisplayText()
    {
        return isHidden ? new string('_', text.Length) : text;
    }
}

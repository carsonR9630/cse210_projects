using System;
public class Word
{
    // attributes
    private string _text = "";
    private bool _isHidden = false;
    public Word(string text)
    {
        _text = text;
    }
    // behavior
    public void Hide()
    {
        // will set _isHidden to true
        _isHidden = true;
    }
    public string GetWordDisplay()
    {
        // returns the underscore if the word should be hidden
        if (_isHidden == true)
        {
            return "______";
        }
        else
        {
            return $"{_text} ";
        }
    }
}
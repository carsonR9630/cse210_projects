using System;
public class Word
{
    // attributes
    private string _text = "";
    private bool _isHidden = false;
    // made a Word constructor for use in Scripture in order to have access to text
    public Word(string text)
    {
        _text = text;
    }
    // behavior
    // made another behavior to check if a word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
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
            return "______ ";
        }
        else
        {
            return $"{_text} ";
        }
    }
}
using System;
public class Word
{
    // attributes
    private string _text = "";
    private bool _isHidden;

    // behavior
    public void Hide()
    {
        // will set _isHidden to true
    }
    public string GetDisplayString()
    {
        // returns the underscore if the word should be hidden
        return "Will put correct string in here later";
    }
}
using System;
public class Reference
{
    // atrributes
    private string _book = "";
    private string _chapter = "";
    private string _startVerse = "";
    private string _endVerse = "";

    // constructors
    public Reference( string book, string chapter, string startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        // constructor for the case that a scripture just has a book and chapter
    }
    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        // constructor for the case where we have the all the references
    }
    public string GetReferenceDisplay()
    {
        if (_endVerse == "")
        {
            return $"{_book} {_chapter}: {_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}
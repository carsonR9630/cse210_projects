using System;
public class Reference
{
    // atrributes
    private string _book;
    private string _chapter;
    private int _startVerse = 0;
    private int _endVerse = 0;

    // constructors
    public Reference( string book, string chapter)
    {
        book = _book;
        chapter = _chapter;
        // constructor for the case that a scripture just has a book and chapter
    }
    public Reference(string book, string chapter, int startVerse, int endVerse)
    {
        book = _book;
        chapter = _chapter;
        startVerse = _startVerse;
        endVerse = _endVerse;
        // constructor for the case where we have the all the references
    }
}
using System;
public class Scripture
{
    // attributes
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    // behaviors
    public void Random()
    {
        // randomly chooses which word will be hidden next
    }
    public void Display()
    {
        // will display the whole scripture for the user to see, both the hidden parts and non-hidden parts
    }
}
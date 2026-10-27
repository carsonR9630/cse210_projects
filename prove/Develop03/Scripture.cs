using System;
using System.IO;
public class Scripture
{
    // attributes
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    // behaviors
    public void LoadScripture()
    {
        string scriptureName = "";
        int numberChosen = 0;
        // gets the file name and loads the file into the word list and some reference variables
        Console.WriteLine("1. Moses 1:39");
        Console.WriteLine("2. Ephesians 2: 19-20");
        // other scriptures
        Console.Write("What scripture would you like to memorize? (Type the number next to the scripture you want): ");
        string userResponse = Console.ReadLine();
        numberChosen = int.Parse(userResponse);
        if (numberChosen == 1)
        {
            scriptureName = "MosesOne.txt";
        }
        else if (numberChosen == 2)
        {
            scriptureName = "EphesiansTwo.txt";
        }
        // add more scriptures later
        string[] lines = System.IO.File.ReadAllLines(scriptureName);
        string book = lines[0];
        string chapter = lines[1];
        string text = "";
        if (lines.Length == 4)
        {
            string startVerse = lines[2];
            _reference = new Reference(book, chapter, startVerse);
            text = lines[3];
        }
        else if (lines.Length == 5)
        {
            string startVerse = lines[2];
            string endVerse = lines[3];
            _reference = new Reference(book, chapter, startVerse, endVerse);
            text = lines[4];
        }
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Word newScripture = new Word (word);
            _words.Add(newScripture);
        }

    }
    public void RandomChoice()
    {
        // randomly chooses which word will be hidden next
        Random randomGenerator = new Random();
        int randomWord = randomGenerator.Next(_words.Count);
        _words[randomWord].Hide();

    }
    public void Display()
    {
        // will display the whole scripture for the user to see, both the hidden parts and non-hidden parts
        Console.WriteLine (_reference.GetReferenceDisplay());
        foreach (Word word in _words)
        {
           Console.Write(word.GetWordDisplay());
        }
    }
}
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
        // gets the file name the user wants and loads the file into the word list and some reference variables
        Console.WriteLine("1. Moses 1:39");
        Console.WriteLine("2. Ephesians 2: 19-20");
        Console.WriteLine("3. 2 Nephi 28:30");
        Console.WriteLine("4. 2 Nephi 2:25");
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
        else if (numberChosen == 3)
        {
            scriptureName = "TwoNephiT.txt";
        }
        else if (numberChosen == 4)
        {
            scriptureName = "TNephiTwenty.txt";
        }
        // read the file into an array called lines
        string[] lines = System.IO.File.ReadAllLines(scriptureName);
        _words.Clear();
        // putting  info into reference points
        string book = lines[0];
        string chapter = lines[1];
        string text = "";
        // instance of reference that only has three reference to pass
        if (lines.Length == 4)
        {
            string startVerse = lines[2];
            _reference = new Reference(book, chapter, startVerse);
            text = lines[3];
        }
        // instance of reference that has all four references to pass
        else if (lines.Length == 5)
        {
            string startVerse = lines[2];
            string endVerse = lines[3];
            _reference = new Reference(book, chapter, startVerse, endVerse);
            text = lines[4];
        }
        // split each of the words on the text line into individual parts, then add them to my words list
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Word newScripture = new Word (word);
            _words.Add(newScripture);
        }

    }
    // added this to be able to check if all the words are hidden
    public bool AllWordsHidden()
    {
        bool allHidden = true;
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                allHidden = false;
            }
        }
        return allHidden;
    }
    public void RandomChoice()
    {
        // called this function so that when it is running my for loop in Program.cs to hide three words,
        // it will still hide left over words if three words aren't remaining
        if (AllWordsHidden())
        {
            return;
        }
        // randomly chooses which word will be hidden next
        Random randomGenerator = new Random();
        int randomWord = 0;
        // makes sure the word that is being hidden isn't currently hidden
        while (_words[randomWord].IsHidden())
        {
            randomWord = randomGenerator.Next(_words.Count);
        }
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
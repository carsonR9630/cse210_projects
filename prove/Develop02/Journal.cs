using System.Security.Cryptography.X509Certificates;
using System.IO;
class Journal
{
    // attributes
    public List<string>_prompts = new List<string>();
    public List<Entry>_entries = new List<Entry>();
    public string _fileName = "";

    // behavior
    public void PromptList()
    {
        // creates the premade list for PickPrompt to choose from
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see God's hand in my life today?");
        _prompts.Add("What was something hard that I accomplished today");
        _prompts.Add("What was one thing I felt I did better at today than yesterday?");
        _prompts.Add("What was the most interesting thing I learned today?");
        _prompts.Add("What's one thing I would do over from today if I could?");
    }
    public string PickPrompt()
    {
        // should be used by AddEntry to randomly choose a prompt to display while adding an entry
        Random randomGenerator = new Random();
        int randomPrompt = randomGenerator.Next(_prompts.Count);
        return _prompts[randomPrompt];
    }
    public void AddEntry()
    {
        // should gather information from user (prompt choice, date (from computer), and response), add to entry list
        int numberChosen = 0;
        Entry newEntry = new Entry();

        do
        {
            Console.WriteLine("Would you like to use a premade prompt or one of your own? Type 1 for premade, 2 for your own:");
            string userResponse = Console.ReadLine();
            numberChosen = int.Parse(userResponse);
            if (numberChosen == 1)
            {
                newEntry._prompt = PickPrompt();
            }
            else if (numberChosen == 2)
            {
                newEntry._prompt = CreatePrompt();
            }
            else
            {
                Console.WriteLine("That is not an option");
            }
        } while(numberChosen != 1 && numberChosen != 2);
        DateTime theCurrentTime = DateTime.Today;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;
        // display that user sees
        Console.WriteLine($"{newEntry._prompt}");
        Console.Write(">> ");
        // response from user added to _response
        newEntry._response = Console.ReadLine();
        // adds all the entries just made into the list
        _entries.Add(newEntry);
    }
    public void DisplayEntry()
    {
        // should display all entries in the entry list (call display from entry class for the structure)
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
    public void LoadJournal()
    {
        // should take a file name, and load contents of file into entries list
        Console.WriteLine("What is the filename?");
        _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        // clears any entries in the list for room for the file
        _entries.Clear();
        for (int i = 0; i < lines.Length; i += 3)
        {
            // Goes through and adds the things in the files to their variables in the list
            Entry loadedEntry = new Entry();
            loadedEntry._date = lines[i];
            loadedEntry._prompt = lines[i + 1];
            loadedEntry._response = lines[i +2];
            _entries.Add(loadedEntry);
        }
    }
    public void SaveEntry()
    {
        // should take contents of entries list and save to a file
        Console.WriteLine("What do you want to name the file?");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry e in _entries)
            {
                // writes the data in _entries into a file
                outputFile.WriteLine(e._date);
                outputFile.WriteLine(e._prompt);
                outputFile.WriteLine(e._response);
            }
        }
    }
    public string CreatePrompt()
    {
        // Exceed requirments, make it so user can make their own prompt
        Console.WriteLine("Write your own prompt:");
        string newPrompt = Console.ReadLine();
        Console.WriteLine("________________");
        return newPrompt;
    }
}
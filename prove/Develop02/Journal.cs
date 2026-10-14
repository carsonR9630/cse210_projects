using System.Security.Cryptography.X509Certificates;

class Journal
{
    // attributes
    public List<string>_prompts = new List<string>();
    public List<Entry>_entries = new List<Entry>();
    public string _fileName = "";

    // behavior
    public void PromptList()
    {
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see God's hand in my life today?");
        _prompts.Add("What was something hard that you accomplished today");
        _prompts.Add("What was one thing you felt you did better at today than yesterday?");
        _prompts.Add("What was the most interesting thing you learned today?");
        _prompts.Add("What's one thing you would do over from today if you could?");
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
        // should gather information from user, add to entry list
        Entry newEntry = new Entry();
        newEntry._prompt = PickPrompt();
        DateTime theCurrentTime = DateTime.Today;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;
        Console.WriteLine($"{newEntry._prompt}");
        newEntry._response = Console.ReadLine();
        _entries.Add(newEntry);
    }
    public void DisplayEntry()
    {
        // should display all entries in the entry list (call display from entry class)
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
        _entries.Clear();
        for (int i = 0; i < lines.Length; i += 3)
        {
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
    }
}
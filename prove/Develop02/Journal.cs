class Journal
{
    // attributes
    public List<string>_prompts = new List<string>();
    public List<Entry>_entries = new List<Entry>();
    public string _fileName = "";

    // behavior
    public void AddEntry()
    {
        // should gather information from user, add to entry list
    }
    public void DisplayEntry()
    {
        // should display all entries in the entry list (call display from entry class)
    }
    public void LoadJournal()
    {
        // should take a file name, and load contents of file into entries list
    }
    public void SaveEntry()
    {
        // should take contents of entries list and save to a file
    }
    public void PickPrompt()
    {
        // should be used by AddEntry to randomly choose a prompt to display while adding an entry 
    }
}
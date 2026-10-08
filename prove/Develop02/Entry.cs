class Entry
{
    // attributes
    public string _date = "";
    public string _prompt = "";
    public string _response = "";

    // behavior
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry - {_response}");
    }
}
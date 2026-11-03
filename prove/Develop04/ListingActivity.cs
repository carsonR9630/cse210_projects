public class ListingActivity : Activity
{
    // attributes
    private List<string>_prompts = new List<string>();
    private List<string>_responses = new List<string>();
    // _responses will hold user responses so they can be counted

    // behavior
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        // constructor of ListingActivity so it can communicate with Activity
    }
    public void GetRandomPrompt()
    {
        // will get a random prompt from the _prompt list and display it
    }
    public void GetResponses()
    {
        // will recieve user input responses into the _response list and display the number of responses for the user to see
    }
}
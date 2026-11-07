public class ListingActivity : Activity
{
    // attributes
    private List<string>_prompts = new List<string>();
    private List<string>_responses = new List<string>();
    // _responses will hold user responses so they can be counted

    // behaviors
    public ListingActivity() : base("Listing Activity", 
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        // constructor of ListingActivity so it can communicate with Activity
    }
    public void GetRandomPrompt()
    {
        // gets a random prompt from the _prompts list and displays it
        _prompts.Add("Who are some of your personal heroes?");
        _prompts.Add("What are some ways you've seen God's hand in your life this week?");
        _prompts.Add("What are you most grateful for?");
        _prompts.Add("What are some of your greatest strengths");
        _prompts.Add("When have you felt the Holy Ghost this Month?");
        _prompts.Add("What are some things you are looking forward to that are going to happen this week?");
        
        Random randomGenerator = new Random();
        int chosenPromptInt = randomGenerator.Next(_prompts.Count);
        string chosenOne = _prompts[chosenPromptInt];

        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"---- {chosenOne} ----");
    }
    public void GetResponses(int seconds)
    {
        // recieves user input responses into the _response list and displays the number of responses for the user to see
        string response;
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            response = Console.ReadLine();
            _responses.Add(response);
        }
        Console.WriteLine("");
        Console.WriteLine($"You have listed {_responses.Count} items!");
    }
}
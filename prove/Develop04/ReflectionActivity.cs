public class ReflectionActivity : Activity
{
    // attributes
    private List<string>_mainPrompts = new List<string>();
    //this second list needs to be related to the the individual parts of main list ??
    private List<string>_relatedPrompts = new List<string>(); 
    private int _chosenMainPrompt;

    // behavior
    public ReflectionActivity() : base("Reflection Activity", 
    "This activity will help you reflect on times in your life when you have shown strength and resilence. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        // constructor of ReflectionActivity so it can communicate with Activity
    }
    public void GetRandomMainPrompt()
    {
        // will get the random main prompt for the user to reflect about from a list of prompts
        _mainPrompts.Clear();

        _mainPrompts.Add("Think of a time you did something really difficult.");
        _mainPrompts.Add("Think of a time you helped someone in need.");
        _mainPrompts.Add("Think of the last time in your life you really struggled.");
        _mainPrompts.Add("Think of a time when you have felt your strongest emotionally.");

        Random randomGenerator = new Random();
        _chosenMainPrompt = randomGenerator.Next(_mainPrompts.Count);
        string chosenString = _mainPrompts[_chosenMainPrompt];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---- {chosenString} ----");
    }
    public int GetRandomRelatedPrompt()
    {
        // will get random related prompts related to the random main prompt, from a list somehow connected to the random main prompt chosen
        if(_chosenMainPrompt == 0)
        {
            _relatedPrompts.Add("How did you feel when it was finally over with? ");
            _relatedPrompts.Add("How did you get started? ");
            _relatedPrompts.Add("What did you learn about yourself during this experience? ");
            _relatedPrompts.Add("How did this experience change how you will approach future difficult things? ");
        }
        else if(_chosenMainPrompt == 1)
        {
           _relatedPrompts.Add("How did you feel when you finished helping them? ");
           _relatedPrompts.Add("How did your service effect the person you helped? ");
           _relatedPrompts.Add("What ripple effects do you think came about because of the help you offered? "); 
        }
        else if(_chosenMainPrompt == 2)
        {
           _relatedPrompts.Add("What was going on in your life that made you struggle? ");
           _relatedPrompts.Add("What changed that brought you out of the struggle? ");
           _relatedPrompts.Add("What did you learn from this time of your life? ");
           _relatedPrompts.Add("How did your life change because of this struggle? ");
           _relatedPrompts.Add("Do you feel like you are better equipt to deal with similar struggles to this if they ever happen? "); 
        }
        else if(_chosenMainPrompt == 3)
        {
           _relatedPrompts.Add("What was it that made you so prepared to feel that way? ");
           _relatedPrompts.Add("Did feeling that strong make the issue easier to deal with? "); 
        }
        return _relatedPrompts.Count;

    }
    public void BeginReflectionActivity(int timer)
    {
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        for(int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();
        do
        {
            Random randomGenerator = new Random();
            int randomChoice = randomGenerator.Next(_relatedPrompts.Count);
            string chosenPrompt = _relatedPrompts[randomChoice];
            _relatedPrompts.RemoveAt(randomChoice);
            Console.Write(chosenPrompt);
            ShowSpinner(timer);
            Console.WriteLine("");
        }while(_relatedPrompts.Count != 0);

    }

}
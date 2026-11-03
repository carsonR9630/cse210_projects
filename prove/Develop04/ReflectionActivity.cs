public class ReflectionActivity : Activity
{
    // attributes
    private List<string>_mainPrompts = new List<string>();
    //this second list needs to be related to the the individual parts of main list ??
    private List<string>_relatedPrompts = new List<string>(); 

    // behavior
    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
        // constructor of ReflectionActivity so it can communicate with Activity
    }
    public void GetRandomMainPrompt()
    {
        // will get the random main prompt for the user to reflect about from a list of prompts
    }
    public void GetRandomRelatedPrompt()
    {
        // will get random related prompts related to the random main prompt, from a list somehow connected to the random main prompt chosen
    }

}
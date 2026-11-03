// this is the parent class
public class Activity
{
    // attributes
    private string _name;
    private string _description;
    private int _duration;

    // behaviors
    public Activity(string name, string description, int duration)
    {
        // constructor
        _name = name;
        _description = description;
        _duration = duration;
    }
    public int GetDuration()
    {
        // will get the duration from the user for use elsewhere in the project
        return 0;
    }
    public void ShowPrologue()
    {
        // will show the begining description of the activity the user selects
    }
    public void ShowSpinner()
    {
        // will be responsible for the timer animations
    }
    public void ShowEpilogue()
    {
        // will show the end description for when the user finishes the activity the user selects
    }
}
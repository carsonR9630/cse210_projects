public abstract class Goal
{
    //attributes
    private string _title;
    private string _description;
    private int _points;

    //behavior
    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }
    // Required so that the other classes can "get" the title
    public string GetTitle()
    {
        return _title;
    }
    // same here but with the description
    public string GetDescription()
    {
        return _description;
    }
    // same but with points
    public int GetPoints()
    {
        return _points;
    }
    // abstract functions to override in each goal type
    public abstract int RecordEvent(); // A function to do the things each child class does when the user records an event
    public abstract string GetStringDetails(); // A function to build the structure of the way the goals will appear when listed
    public abstract string GetSaveString(); // A function to build the structure of how the goals are saved to txt files
}
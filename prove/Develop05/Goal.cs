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
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    // abstract functions to override in each goal type
    public abstract int RecordEvent();
    public abstract string GetStringDetails();
}
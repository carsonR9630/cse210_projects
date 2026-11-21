public class SimpleGoal : Goal
{
    //attributes
    private bool _isCompleted; // keeps track of whether SimpleGoal is completed or not

    //behaviors
    public SimpleGoal(string title, string description, int points) : base(title, description, points)
    {
        _isCompleted = false;
    }
    // Needed for when loading in a file so _isComplete can be loaded
    public void SetCompleted(bool completed)
    {
        _isCompleted = completed;
    }
    public override int RecordEvent()
    {
        // check if the goal is completed already before giving points
        if(_isCompleted == false)
        {
            _isCompleted = true;
            return GetPoints();
        }
        else
        {
            return 0;
        }
    }
    public override string GetStringDetails()
    {
        if (_isCompleted == true)
        {
            return $"[x] {GetTitle()} ({GetDescription()})";
        }
        else
        {
            return $"[ ] {GetTitle()} ({GetDescription()})";
        }
    }
    public override string GetSaveString()
    {
        return $"SimpleGoal,{GetTitle()},{GetDescription()},{GetPoints()},{_isCompleted}";
    }
}
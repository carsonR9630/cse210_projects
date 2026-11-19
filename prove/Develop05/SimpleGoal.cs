public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string title, string description, int points) : base(title, description, points)
    {
        _isCompleted = false;
    }
    public override int RecordEvent()
    {
        _isCompleted = true;
        return GetPoints(); 
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
}
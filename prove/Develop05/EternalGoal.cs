public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points) : base(title, description, points)
    {
        
    }
    public override int RecordEvent()
    {
        return GetPoints();
    }
    public override string GetStringDetails()
    {
        return $"[ ] {GetTitle()} ({GetDescription()})";
    }
    public override string GetSaveString()
    {
        return $"EternalGoal,{GetTitle()},{GetDescription()},{GetPoints()}";
    }
}
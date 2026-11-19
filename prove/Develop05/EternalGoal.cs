public class EternalGoal : Goal
{
    public EternalGoal(String title, string description, int points) : base(title, description, points)
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
}
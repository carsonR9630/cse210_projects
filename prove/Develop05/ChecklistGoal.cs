public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetNumber;
    private int _bonusPoints;

    public ChecklistGoal(string title, string description, int points, int bonusPoints, int targetNumber) : base(title, description, points)
    {
        _bonusPoints = bonusPoints;
        _amountCompleted = 0;
        _targetNumber = targetNumber;
    }
    public override int RecordEvent()
    {
        if(_amountCompleted == _targetNumber)
        {
            return GetPoints() + _bonusPoints;
        }
        else
        {
            _amountCompleted++;
            return GetPoints();
        }
    }
    public override string GetStringDetails()
    {
        if(_amountCompleted == _targetNumber)
        {
            return $"[x] {GetTitle()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_targetNumber}";
        }
        else
        {
            return $"[ ] {GetTitle()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_targetNumber}";
        }
    }
}
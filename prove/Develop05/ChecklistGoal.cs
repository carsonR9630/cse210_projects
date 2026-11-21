public class ChecklistGoal : Goal
{
    // attributes
    private int _amountCompleted; //the amount of times the user has completed parts of the whole goal
    private int _targetNumber; //the whole goal
    private int _bonusPoints;

    //behaviors
    public ChecklistGoal(string title, string description, int points, int bonusPoints, int targetNumber) : base(title, description, points)
    {
        _bonusPoints = bonusPoints;
        _amountCompleted = 0;
        _targetNumber = targetNumber;
    }
    //I need SetAmountCompleted so that when goals are loaded from a save _amountCompleted has a place to go
    public void SetAmountCompleted(int completed)
    {
        _amountCompleted = completed;
    }
    public override int RecordEvent()
    {
        // checking if the user has already completed the goal before giving more points
        if(_amountCompleted >= _targetNumber)
        {
            return 0;
        }
        else
        {
            _amountCompleted++;
            if(_amountCompleted == _targetNumber)
            {
                return GetPoints() + _bonusPoints;
            }
            else
            {
                return GetPoints();
            }
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
    public override string GetSaveString()
    {
        return $"ChecklistGoal,{GetTitle()},{GetDescription()},{GetPoints()},{_bonusPoints},{_targetNumber},{_amountCompleted}";
    }
}
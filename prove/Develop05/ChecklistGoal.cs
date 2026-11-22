public class ChecklistGoal : Goal
{
    private int _goalNumOfTimes = 0;
    private int _currentNumOfTimes = 0;
    private int _bonusPoints = 0;

    public ChecklistGoal(int points, string name, string description, int bonusPoints, int goalNumOfTimes, int currentNumOfTimes) : base(points, name, description)
    {
        _bonusPoints = bonusPoints;
        _goalNumOfTimes = goalNumOfTimes;
        _currentNumOfTimes = currentNumOfTimes;
    }

    public override int RecordEvent()
    {
        _currentNumOfTimes++;
        if (_goalNumOfTimes == _currentNumOfTimes)
        {
            return _points + _bonusPoints;
        }
        
        return _points;
    }
    public override bool IsCompleted()
    {
        bool isCompleted = false;
        if (_goalNumOfTimes <= _currentNumOfTimes)
        {
            isCompleted = true;
        }
        return isCompleted;
    }
    public override string GoalString()
    {
        string counter = $"{_currentNumOfTimes}/{_goalNumOfTimes}";
        string checkbox = "[ ]";
        if (IsCompleted() == true)
        {
            checkbox = "[X]";
        }
        return $"{checkbox} {_name} ({_description}) {counter}";
    }
    public override string SaveFile()
    {
        return $"ChecklistGoal~|~{_points}~|~{_name}~|~{_description}~|~{_bonusPoints}~|~{_goalNumOfTimes}~|~{_currentNumOfTimes}";
    }
}
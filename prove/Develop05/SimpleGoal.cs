public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(int points, string name, string description, bool isCompleted) : base(points, name, description)
    {
        _isCompleted = isCompleted;
    }
    public override int RecordEvent()
    {
        _isCompleted = true;
        return _points;
    }
    public override string SaveFile()
    {
        return $"SimpleGoal~|~{_points}~|~{_name}~|~{_description}~|~{_isCompleted}";
    }
}
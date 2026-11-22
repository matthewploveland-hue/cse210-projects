public class EternalGoal : Goal
{
    public EternalGoal(int points, string name, string description) : base(points, name, description)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }
    public override string SaveFile()
    {
        return $"EternalGoal~|~{_points}~|~{_name}~|~{_description}";
    }
}
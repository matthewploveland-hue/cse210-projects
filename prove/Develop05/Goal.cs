using System.ComponentModel;
using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected int _points = 0;
    protected string _name = "";
    protected string _description = "";
    
    
    public Goal(int points, string name, string description)
    {
        _points = points;
        _name = name;
        _description = description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public abstract int RecordEvent();

    public virtual string GoalString()
    {
        string checkbox = "[ ]";
        if (IsCompleted() == true)
        {
            checkbox = "[X]";
        }
        return $"{checkbox} {_name} ({_description})";
    }
    public virtual bool IsCompleted()
    {//make sure that checkbox changes when isCompleted is true.
        bool isCompleted = false;
        return isCompleted;
    }
    public abstract string SaveFile();
    

    
}
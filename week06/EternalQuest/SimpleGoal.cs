
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override string GetDisplayString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} ({_description})";
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal:{_name}|{_description}|{_points}|{_isComplete}";
    }
}
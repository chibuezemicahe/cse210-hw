using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _current;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _current = 0;
    }

    public override int RecordEvent()
    {
        _current++;
        if (_current == _target)
        {
            _isComplete = true;
            return _points + _bonus;
        }
        return _points;
    }

    public override string GetDisplayString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} ({_description}) -- Completed {_current}/{_target} times";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal:{_name}|{_description}|{_points}|{_target}|{_bonus}|{_current}|{_isComplete}";
    }

    public void SetCurrent(int value)
    {
        _current = value;
    }

    internal new void SetComplete(bool v)
    {
        base.SetComplete(v);
    }
}

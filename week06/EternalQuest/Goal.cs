public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public abstract int RecordEvent();
    public abstract string GetDisplayString();
    public abstract string GetSaveString();

    public string GetName() => _name;
    public bool IsComplete() => _isComplete;
    protected void SetComplete(bool complete)
    {
        _isComplete = complete;
    }
}

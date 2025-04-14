using System;

public class QuestManager
{
    private List<Goal> _goals;
    private int _score;

    public QuestManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            _score += _goals[index].RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
        }
    }

    public int GetScore() => _score;

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string[] data = parts[1].Split("|");

            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])) 
                    );
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    break;
                case "ChecklistGoal":
                    ChecklistGoal goal = new ChecklistGoal(data[0], data[1], 
                        int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]));
                    goal.SetCurrent(int.Parse(data[5]));
                    if (bool.Parse(data[6]))
                    {
                        goal.SetComplete(true);
                    }
                    _goals.Add(goal);
                    break;
            }
        }
    }
}

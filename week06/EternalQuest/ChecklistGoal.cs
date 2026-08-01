// A child class ChecklistGoal from the parent class Goal. Adds member variables _amountCompleted,
// _target, and _bonus. Includes constructor ChecklistGoal, and methods RecordEvent, IsComplete, GetDetailsString,
// GetStringRepresentation. To exceed requirements, methods GetTarget and Duplicate added.

// To exceed requirements, I added a feature that if you complete a Checklist goal, it will ask
// if you would like to recreate that goal, starting again at 0 times complete. If you say Y or y,
// it will recreate an identical Checklist goal while still showing that you finished the previous one.
// See the GetTarget and Duplicate methods below.

// Lee Ward CSE210 July 31, 2026

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    // Used when completing a Checklist goal (exceeding requirements)
    public int GetTarget()
    {
        return _target;
    }

    // Duplicates a Checklist goal if the user desires (exceeding requirements)
    public ChecklistGoal Duplicate()
    {
        return new ChecklistGoal(_shortName, _description, _points, _target, _bonus);
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}

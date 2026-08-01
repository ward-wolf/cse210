// A base (parent) class Goal which has the short name, description, and points. Includes a constructor,
// Goal, and methods RecordEvent, IsComplete, GetDetailsString, GetStringRepresentation.

// Lee Ward CSE210 July 31, 2026

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string status = "[ ]";
        if (IsComplete())
        {
            status = "[X]";
        }
        return $"{status} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}

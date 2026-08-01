// A child class EternalGoal from the parent class Goal.
// Includes constructor EternalGoal, and methods RecordEvent, IsComplete, GetStringRepresentation.

// Lee Ward CSE210 July 31, 2026

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}

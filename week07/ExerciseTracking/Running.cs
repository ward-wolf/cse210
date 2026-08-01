// A child class Running from the parent class Activity. Adds member variable _distance (km).
// Includes a constructor Running, and methods GetActivityType, GetDistance, GetSpeed, GetPace.

// Lee Ward CSE210 August 1, 2026

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override string GetActivityType()
    {
        return "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _minutes * 60;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }
}

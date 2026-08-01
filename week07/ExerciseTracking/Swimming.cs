// A child class Swimming from the parent class Activity. Adds member variable _laps (1 lap = 50 m).
// Includes a constructor Swimming, and methods GetActivityType, GetDistance, GetSpeed, GetPace.

// Lee Ward CSE210 August 1, 2026

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override string GetActivityType()
    {
        return "Swimming";
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _minutes * 60;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
}

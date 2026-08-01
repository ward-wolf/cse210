// A child class Cycling from the parent class Activity. Adds member variable _speed (kph).
// Includes a constructor Cycling, and methods GetActivityType, GetDistance, GetSpeed, GetPace.

// Lee Ward CSE210 August 1, 2026

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override string GetActivityType()
    {
        return "Cycling";
    }

    public override double GetDistance()
    {
        return _speed * _minutes / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}

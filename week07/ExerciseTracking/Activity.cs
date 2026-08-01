// A base (parent) class Activity which has the date and length in minutes. Includes a constructor,
// Activity, and methods GetActivityType, GetDistance, GetSpeed, GetPace, GetSummary.

// Lee Ward CSE210 August 1, 2026

public abstract class Activity
{
    private DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual string GetActivityType()
    {
        return "Activity";
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetActivityType()} ({_minutes} min): Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}

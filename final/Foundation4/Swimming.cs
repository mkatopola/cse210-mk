using System;


class Swimming : Activity
{
    private double _laps;
    private string _activityType;

    public Swimming(double laps, string date, double lengthTime) : base(date, lengthTime)
    {
        _laps = laps;
        _activityType = "Swimming";
    }

    public override double CalculateDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / _lengthTime * 60;
    }

    public override double CalculatePace()
    {
        return _lengthTime / CalculateDistance();
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{_date} {_activityType} ({_lengthTime} min) - Distance: {Math.Round(CalculateDistance(), 2)} km, Speed: {Math.Round(CalculateSpeed(), 2)} Kph, Pace: {Math.Round(CalculatePace(), 2)} min per km");

    }
}

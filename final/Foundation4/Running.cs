using System;


class Running : Activity
{
    private double _distance;
    private string _activityType;

    public Running(double distance, string date, double lengthTime) : base(date, lengthTime)
    {
        _distance = distance;
        _activityType = "Running";
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return _distance / (_lengthTime / 60);
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

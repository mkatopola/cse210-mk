using System;


class Cycling : Activity
{
    private double _speed;
    private string _activityType;

    public Cycling(double speed, string date, double lengthTime) : base(date, lengthTime)
    {
        _speed = speed;
        _activityType = "Cycling";
    }

    public override double CalculateDistance()
    {
        double distance = _speed * _lengthTime / 60;
        return distance;
    }

    public override double CalculateSpeed()
    {
        return _speed;
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

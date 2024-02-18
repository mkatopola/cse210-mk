using System;


public abstract class Activity
{
    protected string _date;
    protected double _lengthTime;

    public Activity(string date, double lengthTime)
    {
        _date = date;
        _lengthTime = lengthTime;
    }

    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();

    public virtual void DisplaySummary()
    {}
}


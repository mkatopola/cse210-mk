using System;

public class EternalGoal : Goal
{
    // Attributes for EternalGoal class
    private string _type = "Eternal Goal:";
    private bool _status;


    // Constructors for EternalGoal class
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _status = false;
    }

    public EternalGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        _status = status;
    }

    // Methods for EternalGoal class

    public override void ListGoal(int i)
    { 
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
    }

    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }

    public override string LoadGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    
      public override void RecordGoalEvent(List<Goal> goals)
    {
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
}


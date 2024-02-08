using System;

public class ChecklistGoal : Goal
{
    // Attributes for ChecklistGoal class
    private string _type = "Check List Goal:";
    private int _numberTimes;
    private int _bonusPoints;
    private bool _status;
    private int _count;

    // Constructors for ChecklistGoal class
    public ChecklistGoal(string type, string name, string description, int points, int numberTimes, int bonusPoints) : base(type, name, description, points)
    {
        _status = false;
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = 0;
    }

    public ChecklistGoal(string type, string name, string description, int points, bool status, int numberTimes, int bonusPoints, int count) : base(type, name, description, points)
    {
        _status = status;
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = count;
    }

    public int GetTimes()
    {
        return _numberTimes;
    }

    public void SetTimes()
    {
        _count = _count + 1;
    }

     public int GetCount()
    {
        return _count;
    }

    public void SetCount()
    {

    }

     public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public bool Finished()
    {
        return _status;
    }

    // Methods for ChecklistGoal class
    public override void ListGoal(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})  --  Currently Completed: {GetCount()}/{GetTimes()}");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})  --  Completed: {GetCount()}/{GetTimes()}");
        }
    }
    
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }

    public override string LoadGoal()
    {
        return ($"Simple Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    
    public override void RecordGoalEvent(List<Goal> goals)
    {
        SetTimes();
        int points = GetPoints();

        if (_count == _numberTimes)
        {
            _status = true;
            points = points + _bonusPoints;
  
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
    }
}


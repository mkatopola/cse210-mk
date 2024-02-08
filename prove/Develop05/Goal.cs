using System;

public abstract class Goal
{
    // Attributes for Goal class 
    private string _type;
    private string _name;
    private string _description;
    private int _points;


    // Constructor for Goal class
    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }
    
    // Getters for Goal class 
    public new string GetType()
    {
        return _type;
    }
    
    public string GetName()
    {
        return _name;
    }
    
    public string GetDescription()
    {
        return _description;
    }
    
    public int GetPoints()
    {
        return _points;
    }


    // Methods for Goal class
    public abstract void ListGoal(int i);
    
    public abstract string SaveGoal();
    
    public abstract string LoadGoal();
    
    public abstract void RecordGoalEvent(List<Goal> goals);
}


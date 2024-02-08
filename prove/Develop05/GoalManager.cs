using System;
using System.IO;

public class GoalManager

{
    // Attributes GoalManager class
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;


    // Constructors GoalManager class
    public GoalManager()
    {
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
    }

    public void AddBonus(int bonusPoints)
    {
        _totalPoints += bonusPoints;
    }

    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    public List<Goal> GetGoalsList()
    {
        return _goals;
    }

    // Methods for GoalManager class
    public void ListGoals()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("\nYour Goals are:");

            int index = 1;
            // Loop though goals list
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
        }

        else
        {
            Console.WriteLine("\nYou currently have no goals!");
        }
    }

    public void RecordGoalEvent()
    {
        ListGoals();

        Console.Write("\nWhich goal did you accomplished?  ");
        int select = int.Parse(Console.ReadLine()) - 1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordGoalEvent(_goals);

        Console.WriteLine($"\nYou have {GetTotalPoints()} points!\n");
    }

    public void DeleteGoal()
    {
        ListGoals();
        
        Console.Write("\nWhich goal do you want to delete?  ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            _goals.RemoveAt(choice);
            Console.WriteLine("Goal successfully deleted.");
        }
        else
        {
            Console.WriteLine("Invalid index. No goal was deleted.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat is the name for this goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            // Save Total Points
            outputFile.WriteLine(GetTotalPoints());
            // Save goals list
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the name of your goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            // read the first line of text file for total stored points
            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);
            // skip the first line of text file to read to goals
            readText = readText.Skip(1).ToArray();
            // loop though text file for goals
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries[1]; 
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal sGoal = new SimpleGoal(type, name, description, points, status);
                    AddGoal(sGoal);
                }

                else if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, description, points, status);
                    AddGoal(eGoal);
                }

                else if (entries[0] == "Check List Goal:")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(type, name, description, points, status, numberTimes, bonusPoints, counter);
                    AddGoal(checklistGoal);
                }
            }
        }
    }
}


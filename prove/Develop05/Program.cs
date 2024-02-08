/*Added a "Delete a Goal" feature to the menu on option 6. It basically lists goals currently loaded into the program and lets the user enter the number in front of the goal they want to delete. Then it gets deleted once they hit enter.*/
using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // converting text to title case
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        GoalManager goals = new GoalManager();

        try
        {
            Console.Clear();
        }
        catch (IOException)
        {
            // Console not available
        }

        Console.Write($"\nYou have {goals.GetTotalPoints()} points!\n");

        // menu
        MainMenu menuChoice = new MainMenu();

        // sub-menu
        GoalMenu goalChoice = new GoalMenu();


        int action = 0;
        while (action != 7)
        // Switch case for main menu
        {
            action = menuChoice.UserChoice();
            switch (action)
            {
                case 1:
                    int goalInput = 0;
                    while (goalInput != 5)
                    // switch case for goals menu
                    {
                        goalInput = goalChoice.GoalChoice();
                        switch (goalInput)
                        {
                            case 1:
                                // Case for Simple Goal
                                Console.Write("What is the name of your goal? ");
                                string name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.Write("What is a short description of your goal? ");
                                string description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?  ");
                                int points = int.Parse(Console.ReadLine());
                                SimpleGoal simpleGoal = new SimpleGoal("Simple Goal:", name, description, points);
                                goals.AddGoal(simpleGoal);
                                goalInput = 5;
                                break;

                            case 2:
                                // Case for Eternal Goal
                                Console.Write("What is the name of your goal? ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.Write("What is a short description of your goal? ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal? ");
                                points = int.Parse(Console.ReadLine());
                                EternalGoal eternalGoal = new EternalGoal("Eternal Goal:", name, description, points);
                                goals.AddGoal(eternalGoal);
                                goalInput = 5;
                                break;

                            case 3:
                                // Case for Checklist Goal
                                Console.Write("What is the name of your goal? ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.Write("What is a short description of your goal? ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal? ");
                                points = int.Parse(Console.ReadLine());
                                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                                int numberTimes = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it that many times? ");
                                int bonusPoints = int.Parse(Console.ReadLine());
                                ChecklistGoal checklistGoal = new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints);
                                goals.AddGoal(checklistGoal);
                                goalInput = 5;
                                break;

                            case 4:
                                // Case for going back to Main Menu
                                goalInput = 5;
                                break;

                            default:
                                Console.WriteLine($"\nPlease enter a valid option.");
                                break;
                        }
                    }
                    break;

                case 2:
                    // Case for Listing Goals
                    try
                    {
                        Console.Clear();
                    }
                    catch (IOException)
                    {
                        // Console not available
                    }

                    Console.Write($"\nYou currently have {goals.GetTotalPoints()} points!\n");
                    goals.ListGoals();
                    break;

                case 3:
                    // Case for Saving goals
                    goals.SaveGoals();
                    break;

                case 4:
                    // Case for Loading goals
                    try
                    {
                        Console.Clear();
                    }
                    catch (IOException)
                    {
                        // Console not available
                    }

                    Console.Write($"\n You currently have {goals.GetTotalPoints()} points!\n");
                    goals.LoadGoals();
                    break;

                case 5:
                    // Case for Recording an event
                    try
                    {
                        Console.Clear();
                    }
                    catch (IOException)
                    {
                        // Console not available
                    }

                    Console.Write($"\nYou currently have {goals.GetTotalPoints()} points!\n");
                    goals.RecordGoalEvent();
                    break;

                case 6:
                    // case for Deleting a Goal
                    try
                    {
                        Console.Clear();
                    }
                    catch (IOException)
                    {
                        // Console not available
                    }

                    Console.Write($"\nYou currently have {goals.GetTotalPoints()} points!\n");
                    goals.DeleteGoal();
                    break;

                case 7:
                    // Console.WriteLine("\nThank you for using the Eternal Quest Program!\n");
                    action = 7;
                    break;
            }
        }
    }
}


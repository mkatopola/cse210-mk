using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Swimming(40, "19 Feb 2024", 30),
            new Running(5, "20 Feb 2024", 30),
            new Cycling(20, "21 Feb 2024", 30),
            new Swimming(40, "22 Feb 2024", 30),
            new Running(5, "23 Feb 2024", 30),
            new Cycling(20, "24 Feb 2024", 30),
        };
        
        Console.Clear();
        Console.WriteLine("*** WELCOME TO THE EXERCISE TRACKER PROGRAM ***\n");
        Console.WriteLine("Here is your exercise schedule for this week.");
        Console.WriteLine("==================================================================================\n");
        foreach (var activity in activities)
        {
            activity.DisplaySummary();
        }
        Console.WriteLine("25 Feb 2024 Resting");
        Console.WriteLine();
        Console.WriteLine("==================================================================================");
    }
}

using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        ShowSpinner(3000); // Show spinner for 3 seconds
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine();
        ShowSpinner(4000); // Show spinner for 4 seconds
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} activity.");
        Console.WriteLine();
        ShowSpinner(4000); // Show spinner for 4 seconds
        Console.Clear();
    }

    public void ShowSpinner(int milliseconds)
    {
        var spinner = new[] { "|", "/", "-", "\\", "|", "/", "-", "\\", }; //Array of spinner characters
        int i = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddMilliseconds(milliseconds);

        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write("\b" + s);
            Thread.Sleep(100);

            i++;

            if (i >= spinner.Length)
            {
                i = 0;
            }
        }
        Console.Write("\b \b"); // This line will delete the last spinner character
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected int Duration
    {
        get { return _duration; }
    }

    protected int GetDuration()
    {
        return _duration;
    }

}


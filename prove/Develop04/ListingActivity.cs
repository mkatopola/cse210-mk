using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt: ");
        string prompt = GetRandomPrompt();
        Console.WriteLine("--- " + prompt + " ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5); // Countdown from 5
        Console.WriteLine();

        GetListFromUser();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> promptList = new List<string>();
        string input;
        var startTime = DateTime.Now;
        do
        {
            if ((DateTime.Now - startTime).TotalSeconds < Duration)
            {
                Console.Write("> ");
                input = Console.ReadLine();
                promptList.Add(input);
                _count++; // Increment the count
            }
        } while ((DateTime.Now - startTime).TotalSeconds < Duration);

        Console.WriteLine($"You listed {_count} items."); // Use _count here
        return promptList;
    }

}

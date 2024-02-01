using System;
using System.Collections.Generic;


public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else",
            "Think of a time when you did something really difficult",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something truly selfless"
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    List<string> _askedQuestions = new List<string>();
    List<string> _askedPrompts = new List<string>();


    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();

        var startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds <= GetDuration())
        {
            DisplayQuestion();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        // If all questions have been asked, repopulate the questions list
        if (_prompts.Count == 0)
        {
            _prompts.AddRange(_askedPrompts);
            _askedPrompts.Clear();
        }

        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        string prompt = _prompts[index];

        // Add the selected question to the asked questions list
        _askedPrompts.Add(prompt);

        // Remove the selected question from the original list
        _prompts.RemoveAt(index);

        return "--- " + _prompts[index] + " ---\n";
    }

    public string GetRandomQuestion()
    {
        // If all questions have been asked, repopulate the questions list
        if (_questions.Count == 0)
        {
            _questions.AddRange(_askedQuestions);
            _askedQuestions.Clear();
        }

        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        string question = _questions[index];

        // Add the selected question to the asked questions list
        _askedQuestions.Add(question);

        // Remove the selected question from the original list
        _questions.RemoveAt(index);

        return "> " + question + " ";
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Thread.Sleep(7000);
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        Console.Clear();
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write(question + "  ");
        ShowSpinner(8000); // Show spinner 
        Console.WriteLine();
    }

}


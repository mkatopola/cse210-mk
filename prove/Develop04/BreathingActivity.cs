using System;
using System.Threading;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        DisplayStartingMessage();
        int breatheInTime = 4; // Breathe in time in seconds
        int breatheOutTime = 6; // Breathe out time in seconds

        Stopwatch stopwatch = new Stopwatch();

        while (true)
        {
            stopwatch.Start(); // Start the stopwatch

            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(breatheInTime); 

            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(breatheOutTime); 
            Console.WriteLine();

            stopwatch.Stop(); // Stop the stopwatch

            // Check if the total elapsed time is greater than or equal to the Duration
            if (stopwatch.Elapsed.TotalSeconds >= Duration)
            {
                break; // Exit the loop
            }
            
        }

        DisplayEndingMessage();

    }

}




/*
The program uses the Stopwatch class in the BreathingActivity to perfectly limit the activity time to what the user had specified
The program makes sure that no random prompts or questions are selected until they have all been used at least once in that session
*/ 

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflecting Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Exit");
            Console.Write("Select a choice from the menu: ");

            string userInput = Console.ReadLine();
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    // Calling the method for Breathing Activity here
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;

                case "2":
                    // Calling the method for Reflecting Activity here
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;

                case "3":
                    // Calling the method for Listing Activity here
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;

                case "4":
                    Console.Write("Exiting the program....");
                    Activity activity = new Activity("", "");
                    activity.ShowSpinner(4000);
                    Console.Clear();
                    return;
                    
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }
        }
    }
}




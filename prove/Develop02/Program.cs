using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        // Creating the PromptGenerator and adding prompts
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator._prompts = new List<string> {"How was my day?", "What did I learn Today?", "What made me happy today?", "What were my two biggest accomplishments today?", "What am I most grateful for today?", "What could I have done better today?"};

        // Creating new journal
        Journal journal = new Journal();
        journal._entries = new List<Entry>();

        while (true)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Getting a random prompt
                    string prompt = promptGenerator.GetRandomPrompt();

                    // Displaying prompt to user and saving their response
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();

                    // Creating a new Entry
                    Entry entry = new(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);
                    entry._promptText = prompt;

                    // Displaying the entry
                    entry.Display();
                    Console.WriteLine();

                    // Adding entry to journal
                    journal.AddEntry(entry);
                    break;

                case "2":
                    // Displaying journal entries
                    journal.DisplayAll();
                    break;

                case "3":
                    // Saving journal to a file
                    journal.SaveToFile();
                    break;

                case "4":
                    // Loading journal from a file
                    journal.LoadFromFile();
                    break;

                case "5":
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid option. Please choose a number between 1 and 5.");
                    break;

            }
        }
    }
}

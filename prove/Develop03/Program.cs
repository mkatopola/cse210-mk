/* 
The program loads random scriptures from a file (scriptures.txt)
*/


using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Scripture> LoadScriptures(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 4)
                {
                    Reference ref1 = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
                    Scripture scripture1 = new Scripture(ref1, parts[3]);
                    scriptures.Add(scripture1);
                }
            }
        }
        return scriptures;
    }

    static void Main(string[] args)
    {
        // Load scriptures from a file
        List<Scripture> scriptures = LoadScriptures("scriptures.txt");

        // Choose a scripture at random
        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture1 = scriptures[index];

        // Print the scripture
        Console.WriteLine(scripture1.GetDisplayText());

        // Prompt the user to press the enter key or type quit
        Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");
        string input = Console.ReadLine();

        while (input.ToLower() != "quit" && !scripture1.IsCompletelyHidden())
        {
            // Hide all words in the scripture
            scripture1.HideRandomWords(3);

            // Clear the console screen
            try
            {
                Console.Clear();
            }
            catch (System.IO.IOException)
            {
                // Handle the case where there is no console to clear
            }

            // Print the scripture
            Console.WriteLine(scripture1.GetDisplayText());

            if (!scripture1.IsCompletelyHidden())
            {
                Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");
                input = Console.ReadLine();
            }
        }

        if (scripture1.IsCompletelyHidden())
        {
            Console.WriteLine("\nAll words in the scripture are now hidden! The program will now exit.\n");
        }
    }
}

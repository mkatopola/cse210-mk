using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();

        // Converting string input to integer 
        int grade = int.Parse(userInput);
        
        string letter = ""; // Initialize the letter variable
        string sign = ""; // Initialize the sign variable
        
        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign for the grade
        if (grade >= 60 && grade < 93) // Excluding the sign for A+ and F
        {
            int lastDigit = grade % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Combine the letter and sign
        string finalGrade = letter + sign;
        Console.WriteLine($"Your grade is {finalGrade}"); // Printing the final grade

        // Printing the pass or fail message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations!! You have passed the class.");
        }
        else
        {
            Console.WriteLine("Am sorry, you did not make it. Try again next semester");
        }
    }
}

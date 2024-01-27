using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine();
        // Create a base "Assignment" object
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        // Creating a new MathAssignment object
        MathAssignment mathAssignment = new MathAssignment("Moffat Katopola", "Calculus", "1.3", "1-10");
        Console.WriteLine(mathAssignment.GetSummary()); // Calling the GetSummary() method
        Console.WriteLine(mathAssignment.GetHomeworkList()); // Calling the GetHomeworkList() method
        Console.WriteLine();

        // Creating new WritingAssignment object
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary()); // Calling the GetSummary() method
        Console.WriteLine(writingAssignment.GetWritingInformation()); // Calling the GetWritingInformation
        Console.WriteLine();

    }
}

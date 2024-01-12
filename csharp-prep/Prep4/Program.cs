using System;
using System.Globalization;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); //creating empty list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (true)
        {
            Console.Write("Enter number: "); //getting numbers from user
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number == 0) 
            {
                break;
            }
            numbers.Add(number);
        }
        int sum = numbers.Sum(); // calculating the sum
        double average = numbers.Average(); // calculating the average
        int max = numbers.Max(); // find the maximum number
        numbers.Sort(); // sorting the numbers
        int? smallestPositive = numbers // getting smallest positive number
            .Where(n => n > 0)
            .DefaultIfEmpty()
            .Min();
                
        // displaying to terminal the sum, average and max
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        if (smallestPositive.Value > 0)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}

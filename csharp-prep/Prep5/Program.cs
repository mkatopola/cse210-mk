using System;

class Program
{
    static void Main(string[] args)
    {
        //calling all program functions
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int numberSquared = SquareNumber(favoriteNumber);
        DisplayResult(userName, numberSquared);
    }

    //PROGRAM FUNCTIONS
    static void DisplayWelcome() //display welcome message
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName() //getting name of user
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber() //getting user's favorite number
    {
        Console.Write("Please enter your favorite number: ");
        string numberStr = Console.ReadLine();
        int favoriteNumber = int.Parse(numberStr); //converting string number to integer number
        return favoriteNumber;  
    }

    static int SquareNumber(int favoriteNumber) // squaring the favorite number
    {
        int numberSquared = favoriteNumber * favoriteNumber;
        return numberSquared;
    }

    static void DisplayResult(string userName, int numberSquared) // displaying to the terminal 
    {
        Console.WriteLine($"{userName}, the square of your number is {numberSquared}");
    }
}

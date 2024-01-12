using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        bool playAgain = true;
        while (playAgain)
        {
            // Console.Write("What is the magic number? ");
            // string userNumber = Console.ReadLine();
            Random random = new Random();
            int number = random.Next(1, 100);
            int guess = 0;
            int guessCount = 0;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
                guessCount ++;

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }

                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }

            }

            Console.Write("Do you want to play again? (yes/no) ");
            string userAnswer = Console.ReadLine();
            playAgain = userAnswer.Equals("yes", StringComparison.OrdinalIgnoreCase);
        }    
            
    }
}


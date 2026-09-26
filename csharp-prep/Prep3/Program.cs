using System;

class Program
{
    static void Main(string[] args)
    {
        // declaring variables
        string userGuessNumber = "";
        // declare guessNumber so it exists outside the do
        int guessNumber = 0;

        // get magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        // start game
        Console.WriteLine("The magic number is between 1 and 100.");

        do
        {
            // get user's guess
            Console.Write("What is your guess? ");
            userGuessNumber = Console.ReadLine();
            // convert from string to integer     
            guessNumber = int.Parse(userGuessNumber);
            // figure out if it's higher or lower
            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }

        } while (magicNumber != guessNumber);
        Console.WriteLine("You guessed it!");


    }
}
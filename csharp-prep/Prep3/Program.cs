using System;

class Program
{
    static void Main(string[] args)
    {
        string userMagicNumber = "";
        string userGuessNumber = "";
        // get magic number
        Console.Write("What is the magic number? ");
        userMagicNumber = Console.ReadLine();

        // get user's guess
        Console.Write("What is your guess? ");
        userGuessNumber = Console.ReadLine();

        // convert from string to integer
        int magicNumber = int.Parse(userMagicNumber);
        int guessNumber = int.Parse(userGuessNumber);

        // determine if its higher, lower, or equal
        if (magicNumber > guessNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (magicNumber < guessNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

    }
}
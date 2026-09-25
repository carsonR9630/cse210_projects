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

        // convert from string to integer
        int magicNumber = int.Parse(userMagicNumber);
        int guessNumber = 0;

        do
        {
            // get user's guess
            Console.Write("What is your guess? ");
            userGuessNumber = Console.ReadLine();     
            guessNumber = int.Parse(userGuessNumber);
            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if ( magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }

        } while (magicNumber != guessNumber);
        Console.WriteLine("You guessed it!");


    }
}
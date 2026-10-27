using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        Scripture scripture = new Scripture();
        Console.WriteLine("Welcome to the Scripture memorization Program!");
        scripture.LoadScripture();
        do
        {
            Console.Clear();
            scripture.Display();
            userInput = Console.ReadLine();
            if (userInput == "")
            {
                for (int i = 0; i < 3; i++)
                {
                    scripture.RandomChoice();
                }
            }
        } while (userInput != "quit");

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput1;
        do
        {
            string userInput2;
            Scripture scripture = new Scripture();
            Console.WriteLine("Welcome to the Scripture memorization Program!");
            scripture.LoadScripture();
            do
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("");
                Console.Write("Press enter to continue or type 'quit' to finish: ");
                userInput2 = Console.ReadLine();
                if (userInput2 == "")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        scripture.RandomChoice();
                    }
                }
            } while (userInput2 != "quit");
            Console.WriteLine("Would you like to try another scripture? (press enter if yes or type 'end' if you would like to end the program)");
            userInput1 = Console.ReadLine();
        } while(userInput1 != "end");
    }
}
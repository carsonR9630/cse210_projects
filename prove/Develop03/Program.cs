using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput1;
        // do-while loop that controls the ability to do more than one scripture in one run
        do
        {
            string userInput2;
            Scripture scripture = new Scripture();
            Console.Clear();
            Console.WriteLine("Welcome to the Scripture memorization Program!");
            scripture.LoadScripture();
            // do-while loop to hides words and reset the scripture with hidden words
            do
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("");
                Console.Write("Press enter to continue or type 'quit' to finish: ");
                userInput2 = Console.ReadLine();
                if (userInput2 == "")
                {
                    if (!scripture.AllWordsHidden())
                    {
                        // only runs when all the words aren't hidden
                        // this for loop makes the RandomChoice repeat 3 times, hiding three words on each click
                        for (int i = 0; i < 3; i++)
                        {
                            scripture.RandomChoice();
                        }
                    }
                    else
                    {
                        // ends the do-while loop
                        userInput2 = "quit";
                    }
                }
            } while (userInput2 != "quit");
            Console.Clear();
            Console.WriteLine("Would you like to try another scripture? (press enter if yes or type 'end' if you would like to end the program)");
            userInput1 = Console.ReadLine();
        } while(userInput1 != "end");
        Console.Clear();
    }
}
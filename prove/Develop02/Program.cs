using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int userNumber = 0;
        journal.PromptList();
        Console.WriteLine("Welcome to the Journal Program!");
        do
        {
            Console.WriteLine("PLease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);
            if (userNumber == 1)
            {
                journal.PickPrompt();
                journal.AddEntry();

            }
            else if (userNumber == 2)
            {
                journal.DisplayEntry();
            }
            else if (userNumber == 3)
            {
                journal.LoadJournal();
            }
            else if (userNumber == 4)
            {
                journal.SaveEntry();
            }
            else if (userNumber == 5)
            {
                // This ends the loop
            }
            else
            {
                Console.WriteLine("That's not an option, try again");
                Console.WriteLine(" ");
            }

        } while(userNumber != 5);
        // I made there be the ability to make your own prompts along with having preset ones I made because sometimes a user might want to answer their own prompt
    }
}
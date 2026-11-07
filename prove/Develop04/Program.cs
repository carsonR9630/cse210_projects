using System;

class Program
{
    static void Main(string[] args)
    {
        // set userChoice outside so that while condition can see it
        string userChoice;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start Listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a number from the menu: ");
            userChoice = Console.ReadLine();

            if(userChoice == "1")
            {
                // Breathing activity
                DateTime startTime = DateTime.Now;
                DateTime endTime; 
                Console.Clear();
                BreathingActivity BA = new BreathingActivity();
                BA.ShowPrologue();
                Console.WriteLine("");
                int breathingDuration = BA.GetDuration();
                Console.Clear(); 
                Console.Write("Get ready... ");
                BA.ShowSpinner(6);
                Console.WriteLine("\n");
                //setting the timer for the while loop
                endTime = startTime.AddSeconds(breathingDuration);
                while (DateTime.Now < endTime)
                {
                    BA.BreatheIn(4);
                    BA.BreatheOut(7);
                }
                Console.Clear();
                BA.ShowEpilogue();
            }
            else if(userChoice == "2")
            {
                // Reflection activity
                Console.Clear();
                ReflectionActivity RA = new ReflectionActivity();
                RA.ShowPrologue();
                Console.WriteLine("");
                int reflectionDuration = RA.GetDuration();
                Console.Clear();
                Console.WriteLine("Get ready...");
                RA.ShowSpinner(6);
                RA.GetRandomMainPrompt();
                // I made this change so that all my related prompts can be shown,
                // it divides the user given duration number by the number of prompts loaded into _relatedPrompts
                // to get the time to spend on each question and still add up to the user's time entry
                int numberOfPrompts = RA.GetRandomRelatedPrompt();
                RA.BeginReflectionActivity(reflectionDuration/numberOfPrompts);
                Console.Clear();
                RA.ShowEpilogue();
            }
            else if(userChoice == "3")
            {
                // Listing activity
                Console.Clear();
                ListingActivity LA = new ListingActivity();
                LA.ShowPrologue();
                Console.WriteLine("");
                int ListingDuration = LA.GetDuration();
                Console.Clear();
                Console.Write("Get ready...");
                LA.ShowSpinner(6);
                Console.WriteLine("");
                LA.GetRandomPrompt();
                LA.GetResponses(ListingDuration);
                LA.ShowEpilogue();
            }
        }while(userChoice != "4");
    }
}
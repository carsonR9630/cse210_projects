using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Eternal Quest goal setting program!");
        Thread.Sleep(2000);
        MenuManager menu = new MenuManager();
        int userChoice = 0;
        do
        {
            menu.DisplayScore();
            Console.WriteLine($"  {menu.LevelUp()}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());

            if(userChoice == 1)
            {
                Console.Clear();
                menu.CreateNewGoal();
            }
            else if(userChoice == 2)
            {
                menu.DisplayGoals();
                Thread.Sleep(3000);
            }
            else if(userChoice == 3)
            {
                menu.SaveGoals();
            }
            else if(userChoice == 4)
            {
                menu.LoadGoals();
            }
            else if(userChoice == 5)
            {
                menu.RecordAchievement();
            }
            else if(userChoice == 6)
            {
                Console.WriteLine("");
                Console.Write("Quiting ");
                Thread.Sleep(1000);
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Not an option, try again.");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }while(userChoice != 6);

    }
}
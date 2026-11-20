using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        //SimpleGoal s1 = new SimpleGoal("Go to my meeting", "Attend the meeting about your job", 20);
        //Console.WriteLine(s1.GetStringDetails());
        //s1.RecordEvent();
        //Console.WriteLine(s1.GetStringDetails());
        //ChecklistGoal c1 = new ChecklistGoal("Attend the temple", "Do any ordinance", 100, 200, 2);
        //Console.WriteLine(c1.GetStringDetails());
        //c1.RecordEvent();
        //Console.WriteLine(c1.GetStringDetails());
        //c1.RecordEvent();
        //Console.WriteLine(c1.GetStringDetails());
        //EternalGoal e1 = new EternalGoal("Read my scriptures", "Read my scriptures every day", 20);
        //Console.WriteLine(e1.GetStringDetails());
        //e1.RecordEvent();
        //Console.WriteLine(e1.GetStringDetails());
        //e1.RecordEvent();
        MenuManager test = new MenuManager();
        test.CreateNewGoal();
        test.DisplayGoals();
        test.CreateNewGoal();
        test.DisplayGoals();
        test.DisplayScore();
        test.RecordAchievement();
        test.DisplayScore();
        test.DisplayGoals();
        test.RecordAchievement();
        test.DisplayScore();
    }
}
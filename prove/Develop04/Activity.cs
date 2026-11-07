// this is the parent class
using System;

public class Activity
{
    // attributes
    private string _name;
    private string _prologue;
    private int _duration;

    // behaviors
    public Activity(string name, string prologue)
    {
        // constructor
        _name = name;
        _prologue = prologue;

    }

    public int GetDuration()
    {
        // gets the duration from the user for use elsewhere in the project
        Console.Write("How long, in seconds, would you like this session to be? ");
        string userResponse = Console.ReadLine();
        _duration = int.Parse(userResponse);
        return _duration;
    }
    public void ShowPrologue()
    {
        // shows the begining description of the activity the user selects
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine(_prologue);
    }
    public void ShowSpinner(int animationRunTime)
    {
        // creates the animation
        List<string> animationStrings = new List<string>();
        animationStrings.Clear();
        // decided on a spining v instead of a line
        animationStrings.Add(">");
        animationStrings.Add("v");
        animationStrings.Add("<");
        animationStrings.Add("^");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(animationRunTime);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if(i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowEpilogue()
    {
        // creates the end description for when the user finishes the activity that was selected
        Console.Write("Well done!! ");
        ShowSpinner(5);
        Console.Write($"\nYou have completed another {_duration} seconds of the {_name}. ");
        ShowSpinner(5);
    }
}
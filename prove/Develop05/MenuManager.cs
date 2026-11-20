using System.ComponentModel;

public class MenuManager
{
    // attributes
    private int _totalScore = 0;
    private List<Goal> _goals = new List<Goal>();

    // behaviors
    public void SaveGoals()
    {
        // will take goals in the list and save it to a txt file in a specific format
    }
    public void LoadGoals()
    {
        // will take goals out of a txt file, and put its information back into the list
    }
    public void DisplayGoals()
    {
        // will display the contnents of the list in a specific format
        int numberOfGoal = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{numberOfGoal}. {goal.GetStringDetails()}");
            numberOfGoal++;
        }
    }
    public void CreateNewGoal()
    {
        // will create new goals to add to the list
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userGoal = Console.ReadLine();
        string name;
        string description;
        int points;
        if(userGoal == "1")
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points you want to earn on completion of this goal? ");
            points = int.Parse(Console.ReadLine());
            SimpleGoal simple = new SimpleGoal(name, description, points);
            _goals.Add(simple);
        }
        else if(userGoal == "2")
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points you want to earn for doing this goal? ");
            points = int.Parse(Console.ReadLine());
            EternalGoal eternal = new EternalGoal(name, description, points);
            _goals.Add(eternal);
        }
        else if(userGoal == "3")
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points you want to earn for completing each part of this goal? ");
            points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int numberTimes = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplising it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());
            ChecklistGoal check = new ChecklistGoal(name, description, points, bonusPoints, numberTimes);
            _goals.Add(check);
        }
        else
        {
            Console.WriteLine("That's not an option");
        }
    }
    public void DisplayScore()
    {
        // will display the current score
        Console.WriteLine($"You have {_totalScore} points.");
    }
    public void RecordAchievement()
    {
        // will record the completion of a goal
        Console.WriteLine("The goals are:");
        int numberDisplay = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{numberDisplay}. {goal.GetTitle()}");
            numberDisplay++;
        }
        Console.Write("Which goal did you want to accomplish? ");
        int usersChoice = int.Parse(Console.ReadLine());
        int points = _goals[usersChoice - 1].RecordEvent();
        _totalScore += points;
    }
}
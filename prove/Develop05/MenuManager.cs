using System.ComponentModel;
using System.IO;
public class MenuManager
{
    // attributes
    private int _totalScore = 0;
    private List<Goal> _goals = new List<Goal>(); //Where the Goal objects are stored

    // behaviors
    public void SaveGoals()
    {
        // takes goals in the list and save it to a txt file in a specific format
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalScore);
            //saves each of the goals in their perspective save formats
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }

    }
    public void LoadGoals()
    {
        // takes goals out of a txt file, and put its information back into the list
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _totalScore = int.Parse(lines[0]); //line[0] is the saved score
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(",");

            string goalType = parts[0]; //parts[0] is where the type of goal is going to be stored
            //parts[1] and on are all the other bits of information, which will be added as needed by these 'if' and 'else if' statements
            if (goalType == "SimpleGoal")
            {
                SimpleGoal s = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                s.SetCompleted(bool.Parse(parts[4]));
                _goals.Add(s);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal e = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(e);
            }
            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal c = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                c.SetAmountCompleted(int.Parse(parts[6]));
                _goals.Add(c);
            }
        }
    }
    public void DisplayGoals()
    {
        // displays the contnents of the list in a specific format
        int numberOfGoal = 1; // used to put the number next to the goal
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{numberOfGoal}. {goal.GetStringDetails()}");
            numberOfGoal++;
        }
    }
    public void CreateNewGoal()
    {
        // creates new goals to add to the list
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userGoal = Console.ReadLine();
        string name; //stores the information for _title
        string description; //stores the information for _description
        int points; //stores the information for _points
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
            Console.Write("What is the amount of points you want to earn for completing just one part of this goal? ");
            points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished before you get a bonus? ");
            int numberTimes = int.Parse(Console.ReadLine()); //stores the information for _targetNumber
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine()); // stores the information for _bonusPoints
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
        // displays the current score
        Console.Write($"You have {_totalScore} points.");
    }
    public void RecordAchievement()
    {
        // records the completion of a goal
        Console.WriteLine("The goals are:");
        int numberDisplay = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{numberDisplay}. {goal.GetTitle()}");
            numberDisplay++;
        }
        Console.Write("Which goal did you want to accomplish? ");
        int usersChoice = int.Parse(Console.ReadLine());
        int points = _goals[usersChoice - 1].RecordEvent(); //records an event and recives the value of the points
        _totalScore += points; //adds the points to the _totalScore
    }
    // A level system to give a goal and purpose for the points and total scores
    public string LevelUp()
    {
        if(_totalScore < 100)
        {
            return "Level 1: Beginner";
        }
        else if (_totalScore < 200)
        {
            return "Level 2: Apprentice";
        }
        else if(_totalScore < 400)
        {
            return "Level 3: Dedicated";
        }
        else if(_totalScore < 600)
        {
            return "Level 4: Accomplished";
        }
        else if(_totalScore < 900)
        {
            return "Level 5: Goal Master!!!";
        }
        else
        {
            return "Level ∞: Goal making Wizard!!!!!";
        }
    }
}
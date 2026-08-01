// A class GoalManager which has the list of goals and the score. Includes constructor GoalManager,
// and methods Start, DisplayPlayerInfo, ListGoalNames, ListGoalDetails, CreateGoal, RecordEvent, SaveGoals,
// LoadGoals.

// To exceed requirements, I added a feature that if you complete a Checklist goal, it will ask
// if you would like to recreate that goal, starting again at 0 times complete. If you say Y or y,
// it will recreate an identical Checklist goal while still showing that you finished the previous one.
// See the RecordEvent method in this file.

// Lee Ward CSE210 July 31, 2026

using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice != "6")
            {
                Console.WriteLine("Please select a valid option.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int number = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{number}. {goal.GetShortName()}");
            number++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int number = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{number}. {goal.GetDetailsString()}");
            number++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        if (goalType == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (goalType == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (goalType == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Please select a valid goal type.");
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        Goal goal = _goals[choice - 1];
        bool wasComplete = goal.IsComplete();

        int pointsEarned = goal.RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points.");
        Console.WriteLine($"You now have {_score} points.");
        Console.WriteLine();

        // If a Checklist goal was just completed on this event, offer to duplicate and reset it
        if (goal is ChecklistGoal)
        {
            ChecklistGoal checklistGoal = (ChecklistGoal)goal;
            if (!wasComplete && goal.IsComplete())
            {
                Console.WriteLine($"You completed {checklistGoal.GetShortName()} by doing it {checklistGoal.GetTarget()} times!");
                Console.Write("Would you like to duplicate this goal and reset it to 0? Y or N. ");
                string answer = Console.ReadLine();

                if (answer == "Y" || answer == "y")
                {
                    _goals.Add(checklistGoal.Duplicate());
                }
            }
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Add points to the file with the WriteLine method
            outputFile.WriteLine(_score);

            // Add goals to the file with the WriteLine method
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string goalType = parts[0];
            string[] details = parts[1].Split(",");

            if (goalType == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(details[0], details[1], int.Parse(details[2]), bool.Parse(details[3])));
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
            }
            else if (goalType == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[4]), int.Parse(details[3]), int.Parse(details[5])));
            }
        }
    }
}

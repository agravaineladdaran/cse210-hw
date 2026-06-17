using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();
            DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("\nSelect a choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    Pause();
                    break;
                case 3:
                    SaveGoals();
                    Pause();
                    break;
                case 4:
                    LoadGoals();
                    Pause();
                    break;
                case 5:
                    RecordEvent();
                    Pause();
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"Level: {GetLevel()}");
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Select a type: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write("Target Completions: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus Points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(
                new ChecklistGoal(
                    name,
                    description,
                    points,
                    target,
                    bonus));
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\nGoals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish?");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Goal Number: ");
        int choice = int.Parse(Console.ReadLine());

        int earnedPoints = _goals[choice - 1].RecordEvent();

        _score += earnedPoints;

        Console.WriteLine(
            $"Congratulations! You earned {earnedPoints} points.");

        Console.WriteLine(
            $"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string fileName = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(fileName))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            string type = parts[0];

            if (type == "SimpleGoal")
            {
                SimpleGoal goal =
                    new SimpleGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]));

                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal goal =
                    new EternalGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]));

                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal goal =
                    new ChecklistGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        int.Parse(parts[5]),
                        int.Parse(parts[4]));

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    private void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    
    public string GetLevel()
    {
        if (_score >= 1500)
            return "Eternal Quest Master";
        else if (_score >= 1000)
            return "Pathfinder";
        else if (_score >= 500)
            return "Disciple";
        else
            return "Beginner";
    }
}
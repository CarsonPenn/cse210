using System;
using System.IO;
using System.Collections.Generic;

public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public int GetTotalPoints() => _totalPoints;

    public void SaveGoals()
    {
        Console.Write("Enter the filename: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        var lines = File.ReadAllLines(fileName);
        _goals.Clear();
        _totalPoints = int.Parse(lines[0]);

        foreach (var line in lines[1..]) // Skip the first line
        {
            var parts = line.Split(",");
            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                    break;
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
            return;
        }

        Console.WriteLine("Your goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].ListGoal();
        }
    }

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public int CalculateTotalPoints()
    {
        _totalPoints = 0;
        foreach (var goal in _goals)
        {
            _totalPoints += goal.CalculatePoints();
        }
        return _totalPoints;
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record progress for. Please add goals first.");
            return;
        }

        ListGoals();

        Console.Write("Enter the number of the goal you completed: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            var selectedGoal = _goals[goalIndex - 1];
            if (!selectedGoal.Complete())
            {
                selectedGoal.RecordEvent();
                int pointsEarned = selectedGoal.CalculatePoints();
                _totalPoints += pointsEarned;

                Console.WriteLine($"Congrats! You earned {pointsEarned} points!");
                Console.WriteLine($"Your grand total is {_totalPoints}.");
            }
            else
            {
                Console.WriteLine("This goal is already completed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please select a valid goal number.");
        }
    }
}

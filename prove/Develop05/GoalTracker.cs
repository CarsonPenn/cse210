// 
using System;
using System.IO;

// goaltracker
// savegoal
// LoadGoals
// List
// add
// calculatetotal points
// record event

public class GoalTracker
{
    // variables and calling 1sts
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public int GetTotalPoints() {
        int points = _totalPoints;
        return points;
    }
// save
    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("Enter the filename... ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int total = GetTotalPoints();
            outputFile.WriteLine(total.ToString());

            foreach(Goal goal in _goals) {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }
// loading goals
    public void LoadGoals() {
        _goals.Clear();

        string fileName = "";
        Console.Write("Please enter filename... ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _totalPoints = Convert.ToInt32(lines[0]);

        for (int i = 1; i < lines.Count(); i++) {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal") {

                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "EternalGoal") {
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                _goals.Add(eternalGoal);
            }
            else if (parts[0] == "ChecklistGoal") {
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]),  Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
                _goals.Add(checklistGoal);
            }
        }
    }

    public void ListGoals() {
    Console.WriteLine("Your goals are:");
        for (int i = 0; i < _goals.Count(); i++) {
            Console.Write($"{i = 1}. ");
            _goals[i].ListGoal();
            Console.Write("");
        }
        Console.WriteLine("");
    }

    public void addGoal(Goal goal) {
        _goals.Add(goal);
    }
    
    public int CalculateTotalPoints() {
        int totalP = _totalPoints;
        foreach(Goal goal in _goals) {
            totalP += goal.CalcualtePoints();
        }
        _totalPoints = totalP;
        return totalP;
    }

    public void RecordEvent() {
        string goalIndex = "";
        Console.Write("Which goal did you finish?");
        goalIndex = Console.ReadLine();
        int goalIndexInt = Convert.ToInt32(goalIndex) - 1;

        if (_goals[goalIndexInt].Complete() == false) {
            _goals[goalIndexInt].RecordEvent();
            int pointsEarned = _goals[goalIndexInt].CalcualtePoints();

            _totalPoints += pointsEarned;
            Console.WriteLine($"Congrats! You have earned {pointsEarned} points!");
            Console.WriteLine($"Your grand total is {_totalPoints}");
        }
        else {
            Console.WriteLine("You've already finished this goal.");
        }
    }
}





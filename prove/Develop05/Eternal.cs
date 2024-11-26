using System;

public class EternalGoal : Goal {
    private int _progress;

    // Default constructor
    public EternalGoal() {
        _name = "";
        _description = "";
        _goalPoints = 0;
        _progress = 0;
    }

    // constructor
    public EternalGoal(string name, string description, int goalPoints) {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _progress = 0;
    }

    // new eternal goal
    public override void CreateChildGoal() {
        Console.Write("Enter the name of the goal: ");
        _name = Console.ReadLine();

        Console.Write("Enter a description for the goal: ");
        _description = Console.ReadLine();

        Console.Write("Enter the points awarded for each completion: ");
        if (int.TryParse(Console.ReadLine(), out int points)) {
            _goalPoints = points;
        } else {
            Console.WriteLine("Invalid input. Setting points to 0.");
            _goalPoints = 0;
        }

        Console.WriteLine("Eternal goal created successfully!");
    }

    // progress
    public override void ListGoal() {
        Console.WriteLine($"[ ] {_name} ({_description}) - Progress: {_progress} times completed");
    }

    // making the eteranal eteranl
    public override bool Complete() {
        return false;
    }

    // Save
    public override string SaveGoal() {
        return $"EternalGoal:{_name},{_description},{_goalPoints},{_progress}";
    }

    // record
    public override void RecordEvent() {
        _progress++;
        Console.WriteLine($"Recorded progress for '{_name}'. Total progress: {_progress}");
    }

    // points according to if done or note
    public override int CalculatePoints() {
        return _goalPoints * _progress;
    }
}

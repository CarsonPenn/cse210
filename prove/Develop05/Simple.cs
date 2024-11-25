/* 
status

Create
GetPoints
Simple(string)*/

using System;

public class SimpleGoal : Goal {
    public SimpleGoal() {
        _name = "Name of Simple Goal";
        _description = "Description of Simple Goal";
        _goalPoints = 0;
        _status = false;
    }

    public SimpleGoal(string name, string description, int goalPoints, bool status) {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _status = status;
    }

    public override void CreateChildGoal() {
        Console.Write("Enter the name of the goal: ");
        _name = Console.ReadLine();

        Console.Write("Enter a description for the goal: ");
        _description = Console.ReadLine();

        Console.Write("Enter the points for completing this goal: ");
        if (int.TryParse(Console.ReadLine(), out int points)) {
            _goalPoints = points;
        } else {
            Console.WriteLine("Invalid input. Setting points to 0.");
            _goalPoints = 0;
        }

        _status = false; // Initialize the status as incomplete.
        Console.WriteLine("");
        Console.WriteLine("Simple goal created successfully!");
    }

    public override void RecordEvent() {
        if (!_status) {
            _status = true;
            Console.WriteLine("Goal marked as complete!");
        } else {
            Console.WriteLine("You have already finished this goal.");
        }
    }

    public override bool Complete() {
        return _status;
    }

    public override void ListGoal() {
        string statusMarker = _status ? "X" : " ";
        Console.WriteLine($"[{statusMarker}] {_name} ({_description})");
    }

    public override int CalculatePoints() { // Fixed typo
        return _status ? _goalPoints : 0;
    }

    public override string SaveGoal() {
        return $"simpleGoal:{_name},{_description},{_goalPoints},{Complete()}";
    }
}

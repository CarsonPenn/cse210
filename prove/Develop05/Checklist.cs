using System;

public class ChecklistGoal : Goal {
    private int _bonusPoints;
    private int _steps;
    private int _progress;

    // default constructor
    public ChecklistGoal() {
        _name = "";
        _description = "";
        _goalPoints = 0;
        _bonusPoints = 0;
        _steps = 0;
        _progress = 0;
    }

    // constructors
    public ChecklistGoal(string name, string description, int goalPoints, int bonusPoints, int steps, int progress) {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _bonusPoints = bonusPoints;
        _steps = steps;
        _progress = progress;
    }

    // new checklist goal
    public override void CreateChildGoal() {
        Console.Write("Enter the name of the goal: ");
        _name = Console.ReadLine();

        Console.Write("Enter a description for the goal: ");
        _description = Console.ReadLine();

        Console.Write("Enter the points awarded for each completed step: ");
        if (int.TryParse(Console.ReadLine(), out int goalPoints)) {
            _goalPoints = goalPoints;
        } else {
            Console.WriteLine("Invalid input. Setting points to 0.");
            _goalPoints = 0;
        }

        Console.Write("How many steps to complete the goal? ");
        if (int.TryParse(Console.ReadLine(), out int steps)) {
            _steps = steps;
        } else {
            Console.WriteLine("Invalid input. Setting steps to 0.");
            _steps = 0;
        }

        Console.Write("Enter the bonus points for completing the goal: ");
        if (int.TryParse(Console.ReadLine(), out int bonusPoints)) {
            _bonusPoints = bonusPoints;
        } else {
            Console.WriteLine("Invalid input. Setting bonus points to 0.");
            _bonusPoints = 0;
        }

        _progress = 0; // Initialize progress to 0 when a new goal is created
        Console.WriteLine("Checklist goal created successfully!");
    }

    // is goal complete
    public override bool Complete() {
        return _progress >= _steps;
    }

    // checklist special progress check
    public override void RecordEvent() {
        if (_progress < _steps) {
            _progress++;
            Console.WriteLine($"Progress for '{_name}': {_progress}/{_steps}");
        } else {
            Console.WriteLine("Goal is already completed!");
        }
    }

    // award progress points
    public override int CalculatePoints() {
        int points = _progress * _goalPoints;
        if (Complete()) {
            points += _bonusPoints; // Award bonus points only if the goal is completed
        }
        return points;
    }

    //goal details
    public override void ListGoal() {
        string statusMarker = Complete() ? "X" : " ";
        Console.WriteLine($"[{statusMarker}] {_name} ({_description}) -- Completed {_progress}/{_steps} steps.");
    }

    // line up to save
    public override string SaveGoal() {
        return $"ChecklistGoal:{_name},{_description},{_goalPoints},{_bonusPoints},{_steps},{_progress}";
    }
}

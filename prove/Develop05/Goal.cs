using System;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected bool _status;

    // Default example
    public Goal()
    {
        _name = "Test Name";
        _description = "Test Description";
        _goalPoints = 50;
        _status = false;
    }

// constructor
    public Goal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _status = false; 
    }

    //  basic outline for a goal
    protected void CreateGoalOutline()
    {
        Console.Write("What is your goal's name?: ");
        _name = Console.ReadLine();
        Console.Write("What is your goal's description?: ");
        _description = Console.ReadLine();
        Console.Write("How many points is this goal worth?: ");
        string stringGoalPoints = Console.ReadLine();

        // getting the goal points
        if (int.TryParse(stringGoalPoints, out int points))
        {
            _goalPoints = points;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to 0 points.");
            _goalPoints = 0;
        }

        _status = false; // Reset status
    }

    //standard save format
    public virtual string SaveGoal()
    {
        return $"Goal: {_name},{_description},{_goalPoints},{_status}";
    }

// overriding to create a new goal
    public virtual void CreateChildGoal()
    {
        // Placeholder 
        Console.WriteLine("Base CreateChildGoal() called. Override in child classes.");
    }

// recording
    public virtual void RecordEvent()
    {
// placeholder
        Console.WriteLine("Goal to be saved");
    }

    // completion status
    public virtual bool Complete()
    {
        return _status;
    }

    // list the goal
    public virtual void ListGoal()
    {
        Console.WriteLine($"Goal: {_name} - {_description} ({_goalPoints} points)");
    }

    // calculate points
    public virtual int CalculatePoints()
    {
        return _goalPoints;
    }
}

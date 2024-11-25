/* Create
GetPoints
Eternal(string) */
using System;

public class EternalGoal : Goal {
    private int _progress;
// eternal goal 
    public EternalGoal() {
        _name = "";
        _description = "";
        _goalPoints = 0;
        _progress = 0;
    }

    public EternalGoal(string name, string description, int goalPoints) {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _progress = 0;
    }
    // Polymorph the child class to become my eternal goal
    public override void CreateChildGoal()
    {
        CreateChildGoal();
    }
    // List goal
    public override void ListGoal() {
    Console.Write($"[ ] {_name} ({_description})");
    }

    // complete?
    public override bool Complete()
    {
        return false;
    }

    public override string SaveGoal() {
        string line = "";
        line = $"EternalGoal: " + _name + "," + _description + "," +_goalPoints.ToString();
        return line;
    }

    // record
    public override void RecordEvent(){
        _progress ++;
    }

    public override int CalcualtePoints() {
      int points = _goalPoints;
      return points;  
    }


}
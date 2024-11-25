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
// simple goal message setup
    public SimpleGoal(string name, string description, int goalPoints, bool status) {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _status = status;
    }

    public override void CreateChildGoal()
    {
        CreateChildGoal();
    }

    public override void RecordEvent() {
        if (_status == false) {
            _status = true;
        }
        else Console.WriteLine("You have already finished this goal.");

    }
    // completed task
    public override bool Complete() {
        if (_status == true) {
            return true;
        }
        else {
            return false;
        }
    }

    public override void ListGoal() {
        string statusMarker = "";
        bool status = Complete();
        if (status == true) {
            statusMarker = "X";
        }
        else {
            statusMarker = " ";
        }
        Console.WriteLine($"[{statusMarker}] {_name} ({_description})");

    }

    // calculate the total points
    public override int CalcualtePoints() {
        bool status = Complete();
        int pTotal = 0;
        if (status == true) {
            pTotal = _goalPoints;
        }
        else {
            pTotal = 0;
        }
        return pTotal;
    }


// saves
public override string SaveGoal() {
    string line = "";
    line = $"simpleGoal:{_name}, {_description}{_goalPoints},{Complete().ToString()}";
    return line;
    }

}
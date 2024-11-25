/* status
bonus

CheckIfBonus
Create
GetPoints(,)
Checklist(string*/

using System;
using System.Dynamic;

// set up variables
public class ChecklistGoal : Goal {
        private int _bonusPoints;
        private int _steps;
        private int _progress;

    public ChecklistGoal() {

    }

    // calling and renamign
    public ChecklistGoal(string name, string description, int goalPoints, int bonusPoints, int steps, int progress) {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _bonusPoints = bonusPoints;
        _steps = steps;
        _progress = progress;

    }
    // create the unique checklist
    public override void CreateChildGoal() {
        CreateGoalOutline();

        Console.Write("How many times does this goal need to be done before points are awarded?");
        string stringChecklistSteps = Console.ReadLine();
        _steps = Convert.ToInt32(stringChecklistSteps);

        Console.Write("What is the bonus point awared?: ");
        string bonusPoints = Console.ReadLine();
        _bonusPoints = Convert.ToInt32(bonusPoints);

        // beging the progress
        _progress = 0;
    }
    public override bool Complete() {
      if (_progress >= _steps) {
        return true;
      } else {
        return false;
      }
    }

    // increment progress
    public override void RecordEvent(){
        _progress ++;
    }
    public override int CalcualtePoints() {
        int points = 0;
        points = _progress * _goalPoints;
        bool status = Complete();

        if (status == true) {
            points += _bonusPoints;
        }
        return points;
    }

    // list goal
    public override void ListGoal() {
        string statusMarker = "";
        bool status = Complete();
        if (status == true) {
            statusMarker = "X";
        } else {
            statusMarker = " ";
        }

        Console.Write($"[{statusMarker}] {_name} ({_description}) --Currently Completed {_progress}/{_steps}");
    }

    public override string SaveGoal() {
        string line = "";
        line = $"ChecklistGoal:" + _name + "," + _description + "," + _goalPoints.ToString() + "," + _bonusPoints.ToString() + "," + _progress.ToString();
        return line;
    }

}
 
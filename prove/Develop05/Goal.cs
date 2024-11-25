/* title
description
PointsValue
type */

/* 
goal
DisplayScore
CreateGoal
Record
GetPoints
GetPoints(,) aka bonus
 */

 using System;

public class Goal{
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected bool _status;

// test
    public Goal()
    {
        _name = "Test Name";
        _description = "Test Description";
        _goalPoints = 50;
        _status = false;
    }

    public Goal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
    }

    protected void CreateGoalOutline()
    {
        Console.Write("What is your goal's name?: ");
        _name = Console.ReadLine();
        Console.Write("What is your goal's description?: ");
        _description = Console.ReadLine();
        Console.Write("How many points is this goal worth?: ");
        string stringGoalPoints = (Console.ReadLine());
        _goalPoints = Convert.ToInt32(stringGoalPoints);

        _status = false;
    }

    public virtual string SaveGoal() {
        string line = "";
        return line;
    }

    public virtual void CreateChildGoal() {

    }

    public virtual void RecordEvent() {

    }

    public virtual bool Complete() {
        return false;
    }

    public virtual void ListGoal() {

    }

    public virtual int CalcualtePoints() {
        return 0;
    }
}
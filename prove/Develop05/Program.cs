using System;
// Load
//Save
// List
// Quit


public class Goal{

    // name and descriptino
    private string _goalName;
    private string _goalDescription;

    public Goal()
    {}

    public Goal(string goalName, string goalDescription);
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
    }

    public string GetGoalName()
    {
        return _goalname;
    }

    public void SetGoalName(string goalName);
    {
        _goalName = GetGoalName;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription
    }

    public virtual void DisplayGoalPoints()
    {
        return;
    }

    public virtual int GetGoalPoints()
    {
        return 0;
    }

    public virtual bool GetGoalStatus()
    {
        return false;
    }

    public virtual string RecordGoal()
    {
        return "";
    }

    public virtual void RecordEvent()
    {}

    public string DisplayGoalName()
    {
        Console.Write("What would you like to name your goal?");
        
    }

}
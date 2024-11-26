using System;
using System.Collections.Generic;

public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public int GetTotalPoints() => _totalPoints;

    public List<Goal> GetGoals() => _goals;

    public void SetTotalPoints(int totalPoints) => _totalPoints = totalPoints;

    public void SetGoals(List<Goal> goals)
    {
        _goals = goals;
    }
// list the goals
    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
            return;
        }

        Console.WriteLine("Your goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].ListGoal();
        }
    }

    public void AddGoal(Goal goal) => _goals.Add(goal);
// calcualte total points
    public int CalculateTotalPoints()
    {
        _totalPoints = 0;
        foreach (var goal in _goals)
        {
            _totalPoints += goal.CalculatePoints();
        }
        return _totalPoints;
    }

    public void RecordEvent()
    // check for goals
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record progress for. Please add goals first.");
            return;
        }

        ListGoals();
// list above will be numbered
        Console.Write("Enter the number of the goal you completed: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            var selectedGoal = _goals[goalIndex - 1];
            if (!selectedGoal.Complete())
            {
                selectedGoal.RecordEvent();
                int pointsEarned = selectedGoal.CalculatePoints();
                _totalPoints += pointsEarned;

                Console.WriteLine($"Congrats! You earned {pointsEarned} points!");
                Console.WriteLine($"Your grand total is {_totalPoints}.");
            }
            else
            {
                Console.WriteLine("This goal is already completed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please select a valid goal number.");
        }
    }
}
// 
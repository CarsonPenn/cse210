using System;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker goals = new GoalTracker();
        bool running = true;

        while (running)
        {
            Console.Clear();
            DisplayMainMenu(goals.CalculateTotalPoints());
            string menuSelect = Console.ReadLine();

            switch (menuSelect)
            {
                case "1":
                    HandleGoalsMenu(goals);
                    break;

                case "2":
                    try
                    {
                        goals.RecordEvent();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                    PauseAndClear();
                    break;

                case "3":
                    HandleSaveLoadMenu(goals);
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Thanks for making your goals come true!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    PauseAndClear();
                    break;
            }
        }
    }
// menu display
    static void DisplayMainMenu(int totalPoints)
    {
        Console.WriteLine($"Your point total is: {totalPoints}");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1) Goals Menu");
        Console.WriteLine("  2) Record Event");
        Console.WriteLine("  3) Save/Load");
        Console.WriteLine("  4) Quit");
        Console.Write("Please make a choice from the menu: ");
    }
    // goal menu

    static void HandleGoalsMenu(GoalTracker goals)
    {
        Console.Clear();
        Console.WriteLine("Goal Types:");
        Console.WriteLine("  1) Simple Goal");
        Console.WriteLine("  2) Eternal Goal");
        Console.WriteLine("  3) Checklist Goal");
        Console.WriteLine("  4) View Goals");
        Console.Write("Which goal would you like to select?: ");
        string goalType = Console.ReadLine();

        switch (goalType)
        {
            case "1":
                SimpleGoal newSimpleGoal = new SimpleGoal();
                newSimpleGoal.CreateChildGoal();
                goals.AddGoal(newSimpleGoal);
                break;
            case "2":
                EternalGoal newEternalGoal = new EternalGoal();
                newEternalGoal.CreateChildGoal();
                goals.AddGoal(newEternalGoal);
                break;
            case "3":
                ChecklistGoal newChecklistGoal = new ChecklistGoal();
                newChecklistGoal.CreateChildGoal();
                goals.AddGoal(newChecklistGoal);
                break;
            case "4":
                goals.ListGoals();
                break;
            default:
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
        }
        PauseAndClear();
    }
// save load menu
static void HandleSaveLoadMenu(GoalTracker goals)
{
    Console.Clear();
    Console.WriteLine("Save/Load Menu:");
    Console.WriteLine("  1) Save");
    Console.WriteLine("  2) Load");
    Console.Write("Please make a choice: ");
    string lsType = Console.ReadLine();

    switch (lsType)
    {
        case "1":
            try
            {
                Console.Write("Enter the filename to save goals: ");
                string fileName = Console.ReadLine();
                GoalFileHandler.SaveGoals(fileName, goals.GetGoals(), goals.GetTotalPoints());
                Console.WriteLine("Goals saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to save goals: {ex.Message}");
            }
            break;
        case "2":
            try
            {
                Console.Write("Enter the filename to load goals: ");
                string fileName = Console.ReadLine();
                var (loadedGoals, totalPoints) = GoalFileHandler.LoadGoals(fileName);
                goals.SetGoals(loadedGoals);
                goals.SetTotalPoints(totalPoints);
                Console.WriteLine("Goals loaded successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load goals: {ex.Message}");
            }
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
    PauseAndClear();
}

// pause/clear, might take this out later, thought it was a good idea
    static void PauseAndClear()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
        Console.Clear();
    }
}

// sources
// stack overflow
// chatgpt
// numerous youtubes
// w3schools

// exceeding requirements, i really struggled with this assignment so i did a simple change to the menu organization in an attempt to make things 
// more clustered together, that way once a user gets to know the program they can quickly do what they would like to do
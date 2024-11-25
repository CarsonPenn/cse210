using System;

class Program {
    static void Main(string[] args) {
        string menuSelect = "";

        GoalTracker goals = new GoalTracker();

        bool running = true;
        while (running) {
            int points = goals.CalculateTotalPoints();

            Console.WriteLine($"Your point total is: {points}");
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1) Goals Menu");
            Console.WriteLine("  2) Record");
            Console.WriteLine("  3) Point Shop");
            Console.WriteLine("  4) Save/Load");
            Console.WriteLine("  5) Quit");
            Console.Write("Please make a choice from the menu: ");

            // Read the user's input and update menuSelect
            menuSelect = Console.ReadLine();

            switch (menuSelect) {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Goal Types");
                    Console.WriteLine("  1) Simple goal");
                    Console.WriteLine("  2) Eternal goal");
                    Console.WriteLine("  3) Checklist goal");
                    Console.WriteLine("  4) VIEW GOALS");
                    Console.Write("Which goal would you like to select?: ");
                    string goalType = Console.ReadLine();

                    switch (goalType) {
                        case "1":
                            SimpleGoal newSimpleGoal = new SimpleGoal();
                            newSimpleGoal.CreateChildGoal();
                            goals.addGoal(newSimpleGoal);
                            break;
                        case "2":
                            EternalGoal newEternalGoal = new EternalGoal();
                            newEternalGoal.CreateChildGoal();
                            goals.addGoal(newEternalGoal);
                            break;
                        case "3":
                            ChecklistGoal newChecklistGoal = new ChecklistGoal();
                            newChecklistGoal.CreateChildGoal();
                            goals.addGoal(newChecklistGoal);
                            break;
                        case "4":
                            goals.ListGoals();
                            break;
                        default:
                            Console.WriteLine("Error, try again");
                            break;
                    }
                    break;

                case "2":
                    goals.RecordEvent();
                    break;

                // Uncomment if PointShop logic is added
                // case "3":
                //     goals.PointShop();
                //     break;

                case "4":
                    Console.WriteLine("Load and Save Menu");
                    Console.WriteLine("  1) Save");
                    Console.WriteLine("  2) Load");
                    Console.Write("Which option would you like to select?: ");
                    string lsType = Console.ReadLine();

                    switch (lsType) {
                        case "1":
                            goals.SaveGoals();
                            break;
                        case "2":
                            goals.LoadGoals();
                            break;
                        default:
                            Console.WriteLine("Error, try again");
                            break;
                    }
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Thanks for making your goals come true!!");
                    break;

                default:
                    Console.WriteLine("Error, try again");
                    break;
            }
        }
    }
}

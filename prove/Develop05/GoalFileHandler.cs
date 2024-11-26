public class GoalFileHandler
{
    public static void SaveGoals(string fileName, List<Goal> goals, int totalPoints)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(totalPoints);
            foreach (var goal in goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public static (List<Goal>, int) LoadGoals(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return (new List<Goal>(), 0);
        }

        try
        {
            var lines = File.ReadAllLines(fileName);
            if (lines.Length < 1)
            {
                Console.WriteLine("The file is empty or corrupted.");
                return (new List<Goal>(), 0);
            }

            int totalPoints = int.Parse(lines[0]);
            var goals = new List<Goal>();

            foreach (var line in lines[1..])
            {
                var parts = line.Split(",");
                if (parts.Length < 2)
                {
                    Console.WriteLine($"Skipping invalid line: {line}");
                    continue;
                }

                switch (parts[0])
                {
                    case "SimpleGoal":
                        if (parts.Length == 5)
                        {
                            goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                        }
                        else
                        {
                            Console.WriteLine($"Invalid SimpleGoal format: {line}");
                        }
                        break;

                    case "EternalGoal":
                        if (parts.Length == 4)
                        {
                            goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        }
                        else
                        {
                            Console.WriteLine($"Invalid EternalGoal format: {line}");
                        }
                        break;

                    case "ChecklistGoal":
                        if (parts.Length == 7)
                        {
                            goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                        }
                        else
                        {
                            Console.WriteLine($"Invalid ChecklistGoal format: {line}");
                        }
                        break;

                    default:
                        Console.WriteLine($"Unknown goal type: {parts[0]}");
                        break;
                }
            }
            Console.WriteLine("Goals loaded successfully!");
            return (goals, totalPoints);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
            return (new List<Goal>(), 0);
        }
    }
}

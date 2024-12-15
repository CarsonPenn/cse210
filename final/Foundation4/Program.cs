using System;

class Program
{
        
    static void Main(string[] args)
    {
        Console.Clear();
        // Console.WriteLine("Hello Foundation4 World!");
        List<Exercise> exerciseList = new List<Exercise>();
//  running
        Running running = new Running("December 13, 2024", 25, 5);
        exerciseList.Add(running);
// swimming
        Swimming swimming = new Swimming("December 13, 2024", 45, 15);
        exerciseList.Add(swimming);
// biking
        Biking biking = new Biking("December 13, 2024", 60, 12);
        exerciseList.Add(biking);

        Console.WriteLine("Exercises Performed: ");
        Console.WriteLine();

// exercise summary loop
        foreach (Exercise exercise in exerciseList) {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}
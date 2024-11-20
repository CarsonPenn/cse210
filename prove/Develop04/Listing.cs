using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    // listing prompts
    private string _randomPrompt { get; set;}
    private List<string> _prompts;

    public ListingActivity() : base()
    {
        SetActivityName("Listing Activity");
        SetActivityDescription("Get ready to reflect on the good going on in your life, you will see a prompt and be guided to list as many as you want.");

        _prompts = new List<string>
        {
            "* What made today a good day? *",
            "* How did you see the hand of the Lord today? *",
            "* Who have you met that has inspired you? *",
            "* What has made you smile lately? *",
            "* What have you done for fun recently? *",
            "* How have you taken time to spend serving others?*",
            "* What goals to you have you set for this month?* "
        };
    }

    // show time for the lsiting activity
    public void RunListingActivity()
    {
        RunActivityStart();
        DisplayPrompt();
        ListingCounter();
        RunActivityEnd();
    }
    // prompt
    private void DisplayPrompt()
    {
        Console.WriteLine("List as many answers to the following questions.");
        Console.WriteLine();
        int randomIndex = new Random().Next(0, _prompts.Count());
        Console.WriteLine(_prompts[randomIndex]);
        Console.WriteLine();
    }

    // list counter !! how could this be simplified????
    private void ListingCounter()
    {
         DateTime startTime = DateTime.Now;
        DateTimeOffset futureTime = startTime.AddSeconds(GetUserLengthInput());
        DateTime currentTime = DateTime.Now;
        int count = 0;
        while (currentTime < futureTime)
        {
            Console.Write(">");
            Console.ReadLine();
            count += 1;
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
        Console.WriteLine($"Great job! You listed {count} items");
        DisplaySpinner(5);
    }
}
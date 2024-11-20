using System;
using System.Collections;
using System.Diagnostics;

public class Activity
// variables and strigns to be used
{
    private string _startMessage;
    private string _endMessage;
    private string _activityDescription;
    private string _activityName;
    static int _spinnerCounter = 0;
    static int _userLength = 0;


    // establish the inherited methosd
    public Activity()
    {
        _spinnerCounter = _userLength = 0;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        _startMessage = $"Welcome to the {_activityName}.";
        Console.WriteLine(_startMessage);
        Console.WriteLine();
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
    }

    public void DisplayEndMessage()
    {
        Console.Clear();
        _endMessage = $"You have done {_userLength} seconds of {_activityName}.";
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Great job! Hope you enjoyed it!");
        DisplaySpinner(3);
        Console.WriteLine();
        Console.WriteLine(_endMessage);
        DisplaySpinner(4);
        Console.ResetColor();
        Console.Clear();
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public void  SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public int GetUserLengthInput()
    {
        return _userLength;
    }

    // spinerjitsu time 
    public void DisplaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        // Console.ForegroundColor = ConsoleColor.Green;

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(150);
        }
        // Console.ResetColor();
        Console.Write(" ");
    }



//time for countdown
    public void DisplayCountdown(int numRunTime)
    {
        for (int i = numRunTime; i >=1; i--)
        {
            Console.Write($"Let's begin in... {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);        }
    }

    // session length
    public void DisplayGetLength()
    {
        Console.WriteLine("How long would you like to do this activity for? (in seconds): ");
        _userLength = int.Parse(Console.ReadLine());
    }
    // session length improved 
//     public void DisplayGetLength()
// {
//     bool isValid = false;

//     while (!isValid)
//     {
//         Console.WriteLine("How long would you like to do this activity for? (in seconds): ");

//         string input = Console.ReadLine();
        
//         // Try to parse the input to an integer
//         if (int.TryParse(input, out _userLength) && _userLength > 0)
//         {
//             isValid = true; // Exit the loop if valid input is entered
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a positive number.");
//         }
//     }
public void DisplayGetReady()
{
    Console.WriteLine("Get ready...");
    DisplaySpinner(4);
}

public void RunActivityStart()
{
    DisplayStartMessage();
    DisplayDescription();
    DisplayGetLength();
    DisplayGetReady();
    Console.Clear();

}

public void RunActivityEnd()
{
    DisplayEndMessage();
}

}




    // alt idea
        // while (stopwatch.ElapsedMilliseconds / 1000 < numRunTime)
        //     {
        //         _spinnerCounter++;
        //         switch (_spinnerCounter % 4)
        //         {
        //             case 0: Console.Write("◜"); break;  // Top-left corner
        //             case 1: Console.Write("◝"); break;  // Top-right corner
        //             case 2: Console.Write("◞"); break;  // Bottom-left corner
        //             case 3: Console.Write("◟"); break;  // Bottom-right corner
        //         }

        //         Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        //         Thread.Sleep(200);
        //     }

         
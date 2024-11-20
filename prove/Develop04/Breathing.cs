using System;
using System.Diagnostics;

// :Activity means its using inheritance to call in parts of Activity class
public class BreathingActivity : Activity 
{

    // opener statement
    public BreathingActivity() : base()
    {
        SetActivityName("Breathing Activity");
        SetActivityDescription("This activity will help you slow down your breathing to help clear your mind. \n You will breath in, hold it, and then release.");
    }
// running the start, activity and end statements
    public void RunBreathingActivity()
    {
        RunActivityStart();
        DisplayBreathCycle();
        RunActivityEnd();
    }

    public void DisplayBreathCycle()
    {
        // variables, 
        int time = GetUserLengthInput() * 1000;
        int intervalTime = 10000;
        int intervals = time / intervalTime;

        for(int i = 0; i< intervals; i++)
        {
            // in
            Console.Write("Breath in. . . ");
            CountUp();
            Console.WriteLine();
            // hold
            Console.Write("Hold . . . ");
            Hold();
            Console.WriteLine();
            // out
            Console.Write("Breath out . . . ");
            CountDown();
            Console.WriteLine();
            
        }
    }
    // in , using the helps from assignment details
    private void CountUp()
    {
        for (int i = 1; i <= 4; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
       // hold
    private void Hold()
    {
        for (int i = 3; i > 0; i-- )
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    // out
    private void CountDown()
    {
        for (int i = 4; i > 0; i-- )
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }










}
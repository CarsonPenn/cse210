// prompt will generate the prompt, from a chosen list,
// outputs th eprompts that have been made
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>
        {
            "Why are you proud of yourself today? ",
            "How did you see the hand of the Lord today? ",
            "Did you learn anything new today? ",
            "What is something that you know now that you wish you did at the beginning of the day? ",
            "What was the best part of today? ",
            "Who made you laugh today? ",
            "What is something you wish you could \"do over\"? ",
            "What is something that you want to do tomorrow? ",
            "Who did you meet that made you smile? ",
            "What do you think you did good today? ",
            "What is something you did for someone else? ",
            "Is there anything you want to revise about this program? If so do it! "
        };

        GetRandomPrompt(prompts);
    }

    static void GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        Console.WriteLine(prompts[index]);
    }
}
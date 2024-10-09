using System;
using System.Dynamic;
// CODE OVERVIEW BELOW
class Program
{
    static void Main(string[] args)
    {
        
// calling the journal and creating a new journal
        Journal journal = new Journal();

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
            "Is there anything you want to revise about this program? If so do it! ",
            "If you had one more hour to spend today, what would you do with it? ",


        };
// using a bool to create a loop that will keep going while quit equals false, the while will keep going so long as while is !quit that means while the quit choice has not been chosen.
        bool quit = false;
        while (!quit)
        {
// menu options
            Console.WriteLine("\n Welcome back to your digital journal!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            // potentially add a settings option, ER #2

            Console.WriteLine("\n What would you like to do?: "):
            string choice = Console.ReadLine():

            switch (choice)
            {
                case "1":
                    string prompt = GetRandomPrompt(prompts);
                    journal.AddEntry(prompt);
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
                    )

                    // add in a case for each of the options
            }

        }

//  goodbye message

    }
        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random():
            int index = random.Next(prompts.Count);
            return prompts[index];

        }
}



// * * * CODE OVERVIEW AND PERSONAL NOTES * * * 
// CALL THE JOURNAL METHOD and create a new journal
// CREATE A MENU LOOP
// CREATE PROMPT RANDOMIZER

// * * * EXCEEDS REQUIREMENTS IDEAS * * * 
// 1) create a loop within the menu loop,
//  so that once you being entering prompts it will ask would you like an additonal prompt? (Y/N)
//  instead of taking the user all the way back to the main menu
// 2) create a way to add prompts? I might be able to get this by creating a settings menu option, 
// i could append the list of prompts
// 3) write into the prompt entry an option to SKIP a prompt and get a new one?

// SOURCES USED github copilot to help autofill and debug code, chatgpt to catch any errors in my code, and to help me figure out how to do a loop within a loop
// case tutorial
// save files tutorial

using System;
using System.Dynamic;
// CODE OVERVIEW BELOW and my sources

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");

        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {   
                //Write
                case 1:
                    journal.NewEntry();
                    Console.WriteLine();
                    break;
                //Display
                case 2:
                    journal.DisplayEntries();
                    Console.WriteLine();
                    break;
                //Load
                case 3:
                    Console.Write("Enter the file name you want to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadEntries(loadFileName);
                    Console.WriteLine();
                    break;
                //Save
                case 4:
                    Console.Write("Enter the file name you want to save (will be saved as csv) ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveEntries(saveFileName);
                    Console.WriteLine("Saved!");
                    Console.WriteLine();
                    break;
                //Quit
                case 5:
                    running = false;
                    Console.WriteLine("See ya later Carson, journal again soon!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("WHOOPS, that's not a valid choice! Please try again.");
                    break;
            }
        }
    }
}


// * * * CODE OVERVIEW AND PERSONAL NOTES * * * 
// CALL THE JOURNAL METHOD and create a new journal
// CREATE A MENU LOOP
// CALL ENTRY TO GET PROMPT, RESPONSE, AND DATE

// * * * EXCEEDS REQUIREMENTS IDEAS * * * 
// 1) create a loop within the menu loop,
//  so that once you being entering prompts it will ask would you like an additonal prompt? (Y/N)
//  instead of taking the user all the way back to the main menu
// 2) create a way to add prompts? I might be able to get this by creating a settings menu option, 
// i could append the list of prompts
// 3) write into the prompt entry an option to SKIP a prompt and get a new one?

// SOURCES USED github copilot to help autofill and debug code, chatgpt to catch any errors in my code, and to help me figure out how to do a loop within a loop
// case/switch tutorial https://www.youtube.com/watch?v=uxTIhRDxJek
// w3schools for review on methods, https://www.w3schools.com/cs/cs_methods.php
// w3schools for boolean tips https://www.w3schools.com/cs/cs_while_loop.php
// abstraction https://www.youtube.com/watch?v=jRkmPRk5j2E

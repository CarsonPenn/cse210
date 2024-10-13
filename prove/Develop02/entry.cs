using System;

public class Entry 
{
    public string _date;
    public string _prompt;
    public string _response;

    public void GenerateDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    public void GeneratePrompt()
    {
        List<string> prompts = new List<string>()
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

        Random rand = new Random();
        bool acceptedPrompt = false;

// Beginning of exceeds requirements part used a trusty boolean to

        while (!acceptedPrompt)
        {
            int randomIndex = rand.Next(prompts.Count);   // this selects a random prompt
            _prompt = prompts[randomIndex];               // heer i assigns the prompt to _prompt
            Console.WriteLine($"Prompt: {_prompt}");      // displays the prompt

            // Asking if the prompt would like to be skipped
            Console.Write("Would you like to skip this prompt? (Y/N): ");
            string userInput = Console.ReadLine().Trim().ToUpper();

            if (userInput == "N")
            {
                acceptedPrompt = true;  // The user accepts the prompt hooray it works!
            }
            else
            {
                Console.WriteLine("Getting you a new prompt...\n");
            }
        }
    }
// End of exceeds requirements part
    public void GetResponse()
    {
        Console.Write("> ");
        _response = Console.ReadLine();
        
        // Console.Write
    }
      // Method to add a new prompt to the list

    
}


// I originally had a prompt and entry methods, decided to combine them to simplify my code.
// I really wanted to have a menu option that would add to the prompt list, 
// but i had a terribly hard time figuring that out, after 2 hours i gave up
// and resorted to something i know and trust, BOOLEANS so ones the get response is loaded it asks if 
// the user wants to skip the displayed prompt or keep it

// Bool w3schools https://www.w3schools.com/cs/cs_booleans.php
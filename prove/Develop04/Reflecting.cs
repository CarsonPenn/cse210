using System;
using System.Diagnostics;
// naming the class
public class ReflectingActivity : Activity
{
    // prompts and questions
    private List<string> _prompts;
    private List<string> _questions;

    // delcaring  NAME and DESCRITPION and creating the lists
    public ReflectingActivity () : base ()
    {
        SetActivityName("Reflection Activity");
        SetActivityDescription("This activity aims to help you remember the times you showed perseverance and courage when facing challanges. \n It asks you a few questions to help you think about what you can do in your current stage of life.");
// promtpz
        _prompts = new List<string>
        {
            "-- Think of a moment when you overcame a fear. . . ",
            "-- Think of a moment when you stayed true to your morals. . . ",
            "-- Think of a moment when you showed courage. . . ",
            "-- Think of a moment when you used faith to overcome a challange. . . ",
            "-- Think of a moment when you didn't give up. . . "
        };
// follow up quesitons
        _questions = new List<string>
        {
            "What made this experience memorable?",
            "Why do you think you did what you did?",
            "How do you think you can take what you learned and use it today?",
            "What helped motivate you at the time?",
            "How has that moment helped you grow?",
            "What do you think that version of you would do now?",
            "Who was around you then? Could they support you now?",
            "What Christlike attribute do you think you increased then?",
            "What is the first step you did?",
            "How has that event changed the way you think now?",
            "What is one person that benefited from what you learned from that experience?"
        };

    }

    // running the program
    public void RunReflectingActivity()
    {
        RunActivityStart();
        DisplayPrompt();
        DisplayQuestions();
        RunActivityEnd();
    }

    // prompt behavior
    public void DisplayPrompt()
    {
        Console.WriteLine("Ponder about this question");
        Console.WriteLine();
        // random prompt
        int randomIndex = new Random().Next(0, _prompts.Count());
        Console.WriteLine(_prompts[randomIndex]);
        Console.WriteLine();
        Console.WriteLine("When you feel ready thoughtful questions press enter to advance.");
        Console.ReadLine();
    }

    // display quesitons :)))
    public void DisplayQuestions()
    {
        List<int> indexes = new List<int>();
    // change the 4 if i feel like this is not enough
        for (int i = 0; i <4; i++)
        {
            int randomInt = new Random().Next(0, _questions.Count());
            while (indexes.Contains(randomInt))
            {
                randomInt = new Random().Next(0, _questions.Count());
            }
            indexes.Add(randomInt);
        }
        // clean things up and start the quesitons
        Console.WriteLine("Contemplate each of the following questions as they relate to your past experience, \n and how it can benefit your current cirumstances.");
        Console.WriteLine();
        DisplayCountdown(5);

        foreach (int index in indexes)
        {
            Console.Write(_questions[index]);
            DisplaySpinner((GetUserLengthInput() / indexes.Count()));
            Console.WriteLine();
        }

    }

}

// ran through chat gpt to find errors
// list tutorial 'Bro Code' https://www.google.com/search?sca_esv=f3da8a737b321c34&rlz=1C5CHFA_enUS1058US1058&q=c%23+lists&tbm=vid&source=lnms&fbs=AEQNm0Aa4sjWe7Rqy32pFwRj0UkWd8nbOJfsBGGB5IQQO6L3J_86uWOeqwdnV0yaSF-x2jpXXSZVlK6C0YPjHbsLu8HQWfm38FRPm5FVWQmVvNxikPuGUro0kULs737NLvYt_770cqPBb-7c9YW98tWSpANkOcZZylZvCbVkKD2SeH_fJOnPgXdUsVXCVyRh_eSp_T6GxUwRZE0bpoVyiYh4GfPMFOiP6w&sa=X&sqi=2&ved=2ahUKEwiCu6i1_emJAxVzNzQIHcZQHZMQ0pQJegQIFRAB&biw=1440&bih=754&dpr=2#fpstate=ive&vld=cid:cfa7676b,vid:vQzREQUhGSA,st:0
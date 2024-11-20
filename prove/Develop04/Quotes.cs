using System;
using System.Security.Authentication.ExtendedProtection;

public class QuotesActivity : Activity
{
    private List<string> _quotes;
// starting message stuff and the list of quotes and affirmations
    public QuotesActivity() : base()
    {
        SetActivityName("Quotes Activity");
        SetActivityDescription("This is best done after the Breathing or Reflecting Activity. \n Sit back and contemplate some kind words of wisdom.");
    
        _quotes = new List<string>
        {
            " Never let a problem to be solved become more important than a person to be loved. -Thomas S. Monson ",
            " A good character is something you must make for yourself. -L. Tom Perry ",
            " Try not to become a man of success, but rather become a man of value. —Albert Einstein",
            " Do or do not, there is no try. -Yoda",
            " Be sure you put your feet in the right place, then stand firm. - Abraham Lincoln",
            " Wherefore, whoso believeth in God might with surety hope for a better world, \n yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, \n which would make them sure and steadfast, always abounding in good works, \n being led to glorify God. -Ether 12:4",
            " Peace I leave with you, my peace I give unto you: not as the world giveth, \n give I unto you. Let not your heart be troubled, neither let it be afraid. -John 24:17"
        };
    }
// run the class
    public void RunQuotesActivity()
    {
        RunActivityStart();
        DisplayQuotes();
        RunActivityEnd();
    }

    public void DisplayQuotes()
    {
       List<int> indexes = new List<int>();

       for (int i = 0; i <4; i++)
       {
            int randomInt = new Random().Next(0, _quotes.Count());
            while (indexes.Contains(randomInt))
            {
                randomInt = new Random().Next(0, _quotes.Count());
            }
            indexes.Add(randomInt);
       }
       foreach (int index in indexes)
       {
        Console.WriteLine(_quotes[index]);
        DisplaySpinner((GetUserLengthInput() / indexes.Count()));
        Console.WriteLine();
       }
    }


}
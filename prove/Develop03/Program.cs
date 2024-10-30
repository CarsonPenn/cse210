using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Let's memorize the good word!");
        Console.WriteLine("Press enter to advance or type 'quit' to exit the program.");

        // scripture + reference
        Reference scriptureReference = new Reference("Doctrine and Covenants", "6", "36", "37");
        Scripture scripture = new Scripture(scriptureReference, "Look unto me in every thought; doubt not, fear not.");
        Word word = new Word(scripture);

        string userInput = "";

        while (userInput != "quit" && word.hasWordsLeft() == true)
        {
            // intro
            Console.WriteLine();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), word.toString()));
            Console.WriteLine();
            userInput = Console.ReadLine();
            word.removeWordsFromText();
        }

        Console.Clear();
        Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), word.toString()));
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Blue; 
        Console.WriteLine("May the force be with you!");






    }
}




// Notes:
// Exceed Requirements ideas

// 

// Sources:
// validated with chat gpt

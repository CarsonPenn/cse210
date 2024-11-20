using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        // while loop
        Console.WriteLine("Welcome back to the Mindfullness Assistant");
        Console.WriteLine("Let's step away from the world for a moment together.");
        Console.WriteLine();
        bool running = true;
        while (running)
        {
            Console.WriteLine("Here are your Mindfulness Activities.");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quotes Activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.WriteLine("Which activity are you in the mood for?");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // switch statmentz
            // breatign 
            switch(choice)
            {
                case 1:
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingActivity();
                    break;
                
                // reflecting
                case 2:
                    Console.Clear();
                    ReflectingActivity reflection = new ReflectingActivity();
                    reflection.RunReflectingActivity();
                    break;
                // listing
                case 3:
                    Console.Clear();
                    ListingActivity listing = new ListingActivity();
                    listing.RunListingActivity();
                    break;
                // quotes and affirmations
                case 4:
                    Console.Clear();
                    QuotesActivity quotes = new QuotesActivity();
                    quotes.RunQuotesActivity();
                    break;
                // quit
                case 5:
                    running = false;
                    Console.WriteLine("Thanks for spending time with yourself today.");
                    Console.WriteLine("Come back soon!");   
                    break;
                default:
                    Console.WriteLine("Invalid input. Clear your mind and try again... ");
                    break;
            }
        }
    }
}
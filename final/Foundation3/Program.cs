using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
// 1st event, lecture thoughts on Finding Nemo by P. Sherman
        Address address1 = new Address("42 Wallaby Way", "Sydney", "New South Wales", 2037, "Australia");
        Lecture lecture = new Lecture("Finding Nemo: Finding ourselves along the way", "Join us to dive deep into the meaning of Pixar's Finding Nemo", "January 1, 2025", "7 pm", address1, "Phillip Sherman", 12000);
        Console.WriteLine();
        // details template
         Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Event Number: 1");
         Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateTemplate());
        // detailed lecture
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());
        // short lecture
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());
        Console.WriteLine();
        Console.WriteLine("--**----**----**----**----**----**----**----**----**--");

// 2nd event, outdoor gathering Cotton-Eyed Joe Convention
        Address address2 = new Address("1138 Cotton Ave.", "Joe Township", "Kentucky", 86793, "America");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Cotton-Eyed Joe Convention", "Come on down to the annual Cotton-Eyed Joe convention, where did he come from and where did he go? We don't know but you know where we are!", "June 7, 2025", "10 Am - Midnight", address2, "sunny");

        Console.WriteLine();
        // details template
         Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Event Number: 2");
         Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateTemplate());
        // detailed outdoor gathering
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());
        // short outdoor gathering
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
        Console.WriteLine();
        Console.WriteLine("--**----**----**----**----**----**----**----**----**--");

// 3rd event, reception for Major Tom
        Address address3 = new Address("1 Space Commerce Way", "Merrit Island", "Florida", 32953, "America");
        Reception reception = new Reception("Major Tom Welcome Home Banquet", "Come Honor Major Tom, a man who risked it all for the further discovery and understanding of our solar system", "March 24, 2025", "6:30 pm", address3, "eventservices@NASA.com", 8675309);
        Console.WriteLine();
        // details template
         Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Event Number: 3");
         Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine(reception.GenerateTemplate());
        // detailed lecture
        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());
        // short lecture
        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());
        Console.WriteLine();
        Console.WriteLine("--**----**----**----**----**----**----**----**----**--");

    }
}
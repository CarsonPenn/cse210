using System;
class Program {
    static void Main(string[] args) {
        Console.Clear();
        List<Video> videosList = new List<Video>();

        // vid 1
        Video video1 = new Video("Pondering thinking, and can it be contemplated?", "BigTimeThinker", 100000000);
        video1.AddComment(new Comment("Aristotle_Real", "I agree with the statements made in this video, I would only add what I have said in the past, It is the mark of an educated mind to be able to entertain a thought without accepting it"));
        video1.AddComment(new Comment("The_Socrates", "The mind is everything; what you think you become! That is why pondering must be contemplated!!!"));
        video1.AddComment(new Comment("Doug2000", "Word. da way a dude thinks is cuz of the brain he be thinking with, and I stand by that"));
        videosList.Add(video1);

        // vid 2
        Video video2 = new Video("Pineapple on pizza? Is there an answer", "PizzaFanatic", 25);
        video2.AddComment(new Comment("PineApple_4Evah", "There is literally nothing better on pizza, y'all need to stop adding meats and veggies, that's what is gross"));
        video2.AddComment(new Comment("The_Socrates", "@PizzaFanatic, thanks for being brave enough to share your thoughts"));
        video2.AddComment(new Comment("ninja89!!", "Does anyone know the recipe he used in the video? Asking for a friend"));
        videosList.Add(video2);

        // vid 3
        Video video3 = new Video("LOTR: The Gladden River, true lord of the rings?", "LOTR Oddities", 400);
        video3.AddComment(new Comment("pokemon_fan1398", "I wonder if videos like this make Tolkien roll in his grave"));
        video3.AddComment(new Comment("gigaChadGondor", "Nah fam, Déagol should be the real lord, he was the first one in like two and a half millennia, that takes guts. #Déagol4life"));
        video3.AddComment(new Comment("FrodoFam:)", "A river is not a sentient being, it don't have fingers you ninnyhammer"));
        videosList.Add(video3);

        // video details seciotn
        foreach (Video video in videosList) {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine(new string('-', 150));
        }
    }
}
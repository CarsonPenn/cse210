using System;
public class Video {
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length) {
        _title = title;
        _author = author;
        _length = length;
    }

    // add comment
    public void AddComment(Comment comment) {
        _comments.Add(comment);
    }

    public int CountComments() {
        return _comments.Count;
    }

    // Displaying stuff section
    public void DisplayInfo() {
// aligning the colums thanks to a few youtube videos and chatgpt
        Console.WriteLine($"{"Title",-50} | {"Creator",-20} | {"Length",8}");
        Console.WriteLine(new string('-', 85)); 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{_title,-50} | {_author,-20} | {_length,10:N0} seconds");

        // display comment count
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{"Number of comments:",-30} {CountComments()}");
        Console.WriteLine(new string('-', 85));

        //  comment display
        foreach (Comment comment in _comments) {
            comment.DisplayInfo();
        }
    }
}

using System;
public class Comment {
    private string _username;
    private string _content;

    public Comment(string username, string content) {
        _username = username;
        _content = content;
    }

    public void DisplayInfo() {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{"Username:",-15} {_username}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{"Comment:",-15} {_content}");
        Console.WriteLine();
    }
}

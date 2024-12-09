
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

    //add comment
    public void AddComment(Comment comment) {
        _comments.Add(comment);
    }


    public int CountComments() {
        return _comments.Count;
    }

// display
    public void DisplayInfo() {
        Console.WriteLine($"Title: {_title} | Creator: {_author} | Length: {_length} seconds.");
        Console.WriteLine();
        Console.WriteLine($"Number of comments: {CountComments()}");
        foreach (Comment comment in _comments) {
            comment.DisplayInfo();
        }
    }
}
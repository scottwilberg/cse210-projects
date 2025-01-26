using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int numberOfComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine(new string('*', 100));
        Console.WriteLine($"Title: \"{_title}\" Author: \"{_author}\" Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {numberOfComments()}");
        Console.WriteLine(new string('-', 100));
        Console.WriteLine("Comments: ");

        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment._name}, {comment._commentText}");
        }
    }
}
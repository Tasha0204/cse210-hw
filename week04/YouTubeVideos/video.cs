using System;
public class Video
{
    private string _title;
    private string _author;
    private double _lengthSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        int count = 0;
        count = _comments.Count;
        return count;
    }
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_lengthSeconds}seconds");
        Console.WriteLine();
        int commentCount = GetNumberOfComments();
        Console.WriteLine($"Number of comments: {commentCount}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }
    }
}
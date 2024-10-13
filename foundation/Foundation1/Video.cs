using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Video
{
    public string _title3;

    public string _author;

    public int _lengthSeconds;

    public int _seconds;
    public List<Comment> Comments;

    public Video (string title, string author, int lenthSeconds )
    {
        _title3 = title;
        _author = author;
        _lengthSeconds = lenthSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
 

    public void VideoRun()

    {

        Console.WriteLine($"Title:{_title3}");
        Console.WriteLine($"Author:{_author}");
        Console.WriteLine($"Length:{_lengthSeconds} Seconds");
        Console.WriteLine($"Comment Section");
        
        foreach(Comment comment in Comments)
        {
           
        comment.DisplayCommentInfo();
        
        }
    }
    








}






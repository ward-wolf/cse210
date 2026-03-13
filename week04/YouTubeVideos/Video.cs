// A class called Video that stores information about each video

// Steve Ward CSE210 March 12, 2026

using System;
using System.Collections.Generic;

class Video
{ 
    private string _Title;
    private string _Author;
    private int _Length;

    private List<Comment> _Comments; 

    public Video(string title, string author, int length)
    {
        _Title = title;
        _Author = author;
        _Length = length;
        _Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _Comments.Add(comment);
    }

    public string GetTitle()
    {
        return _Title;
    }       

    public string GetAuthor()
    {
        return _Author;
    }

    public int GetLength()
    {
        return _Length;
    }

    public List<Comment> GetComments()
    {
        return _Comments;
    }

    public int GetCommentCount()
    {
        return _Comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine("Title: " + _Title);
        Console.WriteLine("Author: " + _Author);
        Console.WriteLine("Length: " + _Length + " seconds");
        Console.WriteLine("Comment Count: " + _Comments.Count);
        Console.WriteLine("Comments:");
        foreach (Comment comment in _Comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }

}

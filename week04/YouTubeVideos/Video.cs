// A class called Video that stores information about each video

// Steve Ward CSE210 March 12, 2026

using System;
using System.Collections.Generic;

class Video
{ 
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments; 

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

    public string GetTitle()
    {
        return _title;
    }       

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Length: " + _length + " seconds");
        Console.WriteLine("Comment Count: " + _comments.Count);
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }

}

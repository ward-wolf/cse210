// A comment class that tracks the name of the commenter and the comment text.

// Lee Ward CSE210 July 2, 2026

using System;

class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _text;
    }

    public void DisplayComment()
    {
        Console.WriteLine(_name + ": " + _text);
    }


}
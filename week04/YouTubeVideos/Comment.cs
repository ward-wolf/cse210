// A comment class that tracks the name of the commenter and the comment text.

// Steve Ward CSE210 March 12, 2026

using System;

class Comment
{
    private string _Name;
    private string _Text;

    public Comment(string name, string text)
    {
        _Name = name;
        _Text = text;
    }

    public string GetName()
    {
        return _Name;
    }

    public string GetText()
    {
        return _Text;
    }

    public void DisplayComment()
    {
        Console.WriteLine(_Name + ": " + _Text);
    }


}
// A class called Reference which holds the book, chapter, and verse(s) for a scripture.

// Steve Ward CSE210 March 5, 2026

using System;
public class Reference
{

    // Create member variables and make them private

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Create a function which has a book, chapter, and single verse
    
    public Reference (string book, int chapter, int verse)    
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    // Create a function which has a book, chapter, and range of verses

    public Reference (string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Display the verse reference

    public string GetDisplayText ()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }

        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
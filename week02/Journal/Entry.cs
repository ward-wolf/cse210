// A class called Entry which holds journal entries including the date, the prompt, and the entry.
// Displays the entry using a set format.

// Steve Ward CSE210 March 2, 2026

using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()      
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}
// A class called PromptGenerator which holds ideas for journal entries and randomly provides one.
// Added an option for the user to add additional prompts for future use during the same session, see lines 11-14.
// Lee Ward CSE210 June 30, 2026

using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }
    public string GetRandomPrompt()
    {   
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}   

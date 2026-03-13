// Exceeded requirements by modifying the function HideRandomWords to only hide additional words 
// each time the user presses enter (i.e., it will not repeat hiding a word). See lines 37-57.

// A class called Scripture which holds the reference and words for a scripture.

// Steve Ward CSE210 March 5, 2026

using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{

    // Create member variables and make them private

    private Reference _reference;
    private List<Word> _words;

    // Create a new scripture with a reference and verse text.

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // Create a list with the words of the scripture

        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    // A function which will randomly hide a certain number of words in the scripture verse. 
    // This will only hide additional words and previously hidden words will remain hidden. 

    public void HideRandomWords (int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        // Get a list of words that are currently visible
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        // Hide words until we reach the requested number or run out of visible words
        while (hiddenCount < numberToHide && visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            
            visibleWords.RemoveAt(index);
            hiddenCount++;
        }
    }

    // A function to get the text to display with hidden words

    public string GetDisplayText ()
    {
        string scriptureText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return scriptureText.Trim();
    }

    // A function to determine if all words in a scripture are hidden

    public Boolean IsCompletelyHidden ()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
}

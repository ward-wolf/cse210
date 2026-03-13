// A class called Word which hides or shows each word in a scripture verse

// Steve Ward CSE210 March 5, 2026

using System;
public class Word
{
    // Create member variables and make them private

    private string _text;
    private Boolean _isHidden;

    // Create a new word and make it not hidden to start.

    public Word (string text)
    {
        _text = text;
        _isHidden = false;
    }

    // If the word will be hidden, set isHidden to true. 

    public void Hide ()
    {
        _isHidden = true;
    }

    // Return whether the word is hidden or not. 
    
    public Boolean IsHidden ()
    {
        return _isHidden;
    }

    // Either display the word or replace the letters of the word with _.
    // Currently, this will also change punctuation to a _ when the word it is next to is hidden. 

    public string GetDisplayText ()
    {
        if (_isHidden == true)
        {
            string hiddenText = "";

            foreach (char letter in _text)
            {
                hiddenText += "_";
            }
            return hiddenText;
        }

        else
        {
            return _text;
        }
    }
}

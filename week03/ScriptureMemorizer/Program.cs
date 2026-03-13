// To exceed requirements I adjusted the hiding words feature so it will only hide additional words every 
// time you hit enter (refer to the Scripture.cs file for this code). I also figured out how to break up long texts, 
// such as the text of the verse or verses, into multiple lines to make the code easier to read. See lines 22-23 in this file.
// You can follow this pattern for even longer verses with more lines. 

// A program to run the Scripture Memorizer Program, which stores the scripture and user interface controls. 

// Steve Ward CSE210 March 12, 2026

using System;

// Creates a class named Program to run the Scripture Memorizer

class Program
{
    static void Main(string[] args)
    {

        // Creates a new scripture to memorize. In this case, the scripture is fixed. 

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string verseText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; " +
            "in all thy ways acknowledge Him, and he shall direct thy paths.";
        Scripture scripture1 = new Scripture(reference, verseText);

        // Take user input, either hit enter or quit.

        string input = "";

        // If the user hits enter, hide more of the scripture words

        while (input.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine();

            // If all words have been hidden, end the program. 

            if (scripture1.IsCompletelyHidden())
            {
                break;
            }

            // Give user option to hide more words or quit

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine();

            // Hide 3 random words each time the user hits enter

            scripture1.HideRandomWords(3);
        }
    }
}
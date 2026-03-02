// Main program to run the Journal app. 

// Added the following extra creativity to exceed requirements:
// - a feature so the user can add a prompt of their choice (works with the PromptGenerator.cs file) 
//      and use that prompt for a new entry now or have it as a random possibility later in that session
// - an error message if the user enters an invalid choice
// - a goodbye message

// Steve Ward CSE210 March 2, 2026

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        // Add some initial prompts
        promptGenerator.AddPrompt("Who was the most interesting person I interacted with today?");
        promptGenerator.AddPrompt("What was the best part of my day?");
        promptGenerator.AddPrompt("How did I see the hand of the Lord in my life today?");
        promptGenerator.AddPrompt("What was the strongest emotion I felt today?");
        promptGenerator.AddPrompt("If I had one thing I could do over today, what would it be?");

        // Create user menu and main loop

        Console.WriteLine("Welcome to the Journal Program!");
        int choice = -1;

        while (choice != 6)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Add a prompt ");
            Console.WriteLine("6. Quit ");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            // Allow the user to write a new entry

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Console.Write("> ");
                string entryText = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = prompt;
                newEntry._entryText = entryText;

                theJournal.AddEntry(newEntry);
            }

            // Allow the user to display all entries

            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }

            // Allow the user to load entries from a file

            else if (choice == 3)
            {
                Console.WriteLine("What is the file name? ");
                string loadFilename = Console.ReadLine();
                theJournal.LoadFromFile(loadFilename);
            }

            // Allow the user to save entries to a file

            else if (choice == 4)
            {
                Console.WriteLine("What is the file name? ");
                string saveFilename = Console.ReadLine();
                theJournal.SaveToFile(saveFilename);
            }

            // Allow the user to add a new prompt

            else if (choice == 5)
            {
                Console.WriteLine("Please enter a new prompt: ");
                string newPrompt = Console.ReadLine();
                promptGenerator.AddPrompt(newPrompt);
                Console.WriteLine("Prompt added successfully!");
                Console.WriteLine("Would you like to use this new prompt for an entry now? (y/n)");
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    Console.WriteLine(newPrompt);
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    Console.Write("> ");
                    string entryText = Console.ReadLine();

                    Entry newEntry = new Entry();
                    newEntry._date = dateText;
                    newEntry._promptText = newPrompt;
                    newEntry._entryText = entryText;

                    theJournal.AddEntry(newEntry);
                }
                else if (response == "n")
                {
                    Console.WriteLine("Prompt added for this session.");
                }
                else
                {
                    Console.WriteLine("Invalid response. Please enter y or n.");
                }
            }

            // Allow the user to quit

            else if (choice == 6)
            {
                choice = 6;
            }

            // Handle invalid choices

            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        // Display a goodbye message

        Console.WriteLine("Goodbye!");
    }
}
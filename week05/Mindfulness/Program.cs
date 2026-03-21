// Exceeded requirements by #1 adding a Goodbye message and error if an invalid menu choice is made. (See lines 50-58)
// And, #2 in Reflection.cs, made it so no question is reused until all the questions have been shown to the user. 

// A Program to run the Mindfulness program. 

// Steve Ward CSE210 March 20, 2026

using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        int duration = 0;
        string name = "";
        string description = "";
        while (choice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();
            if (choice == 1)
            {
                name = "Breathing";
                description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity breathingActivity = new BreathingActivity(name, description, duration);
                breathingActivity.Run();
            }
            else if (choice == 2)
            {
                name = "Reflecting";
                description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
                ReflectingActivity reflectingActivity = new ReflectingActivity(name, description, duration);
                reflectingActivity.Run();
            }
            else if (choice == 3)
            {
                name = "Listing";
                description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                ListingActivity listingActivity = new ListingActivity(name, description, duration);
                listingActivity.Run();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}

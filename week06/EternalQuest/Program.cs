// Program to run the EternalQuest Program. Creates the main entry point and starts the program.

// To exceed requirements, I added a feature that if you complete a Checklist goal, it will ask
// if you would like to recreate that goal, starting again at 0 times complete. If you say Y or y,
// it will recreate an identical Checklist goal while still showing that you finished the previous one.
// See comments in GoalManager and CheckListGoal for specific areas implementing this.

// Lee Ward CSE210 July 31, 2026

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}

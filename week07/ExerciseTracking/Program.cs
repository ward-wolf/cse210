// Program to run the ExerciseTracking Program. Creates the main entry point and starts the program.

// Lee Ward CSE210 August 1, 2026

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(new DateTime(2026, 8, 1), 30, 4.8);
        Cycling cycling = new Cycling(new DateTime(2026, 8, 1), 45, 20.0);
        Swimming swimming = new Swimming(new DateTime(2026, 8, 1), 40, 30);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

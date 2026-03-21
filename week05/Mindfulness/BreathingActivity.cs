// Breathing activity child class under parent class Activity. Includes a constructor and a run method. 

// Steve Ward CSE210 March 20, 2026

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    
    }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsedTime = 0;
        int breathingTime = 3;
        while (elapsedTime < _duration)
        {
            Console.Write("Breathe in...");
            ShowCountDown(breathingTime);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(breathingTime);
            Console.WriteLine();
            Console.WriteLine();
            elapsedTime += 2 * breathingTime;
            if (breathingTime < 8)
                breathingTime += 1;
        }
        
        DisplayEndingMessage();
    }
}
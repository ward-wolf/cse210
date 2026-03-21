// A parent class Activity which has the name, description, and duration. Includes methods 
// Activity, DisplayStartingMessage, DisplayEndingMessage, ShowSpinner, ShowCountDown.

// Steve Ward CSE210 March 20, 2026

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        int countDown = 3;
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(countDown);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        int countDown = 3;
        Console.WriteLine("Well done!!");
        ShowSpinner(countDown);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(countDown);
        Console.Clear();
    }

    protected void ShowSpinner(int countDown)
    {
        string[] frames = [ "|", "/", "-", @"\" ];
        int totalFrames = countDown * 4;
        for (int i = 0; i < totalFrames; i++)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.Write(" \b");
        Console.WriteLine();
    }

    protected void ShowCountDown(int countDown)
    {
        for (int timeLeft = countDown; timeLeft > 0; timeLeft--)
        {
            Console.Write(timeLeft);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
 
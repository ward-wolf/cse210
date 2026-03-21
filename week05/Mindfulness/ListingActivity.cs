// A child class ListingActivity from the parent class Activity. Includes member variables _count and _prompts.
// It has a constructor and run method. It also has GetRandomPrompt and GetListFromUser methods.

// Steve Ward CSE210 March 20, 2026

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _count = 0;
        _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(0, _prompts.Count);
        Console.WriteLine($" --- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration); 
        DateTime currentTime = startTime;
        while (currentTime < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            list.Add(input);
            _count++;
            currentTime = DateTime.Now;
        }
        return list;
    }
}
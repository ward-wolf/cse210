// For creativity/exceeding requirements, made it so it will not show a duplicate question until all questions have been shown, see lines 58-67

// A child class ListingActivity from the parent class Activity. Includes member variables _prompts:List<String> and 
// _questions:List<String>. It has a constructor and run method. Also includes methods GetRandomPrompt, GetRandomQuestion,
// DisplayPrompt, and DisplayQuestion. 

// Steve Ward CSE210 March 20, 2026

public class ReflectingActivity : Activity
{
    private List<String> _prompts;
    private List<String> _questions;
    private List<String> _remainingQuestions;
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
        _remainingQuestions = [];
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(3);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;
        _remainingQuestions = [.._questions];
        while (currentTime < endTime)
        {
            DisplayQuestions();
            Thread.Sleep(5000);
            currentTime = DateTime.Now;
        }
        Console.WriteLine(); 
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(0, _prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        if (_remainingQuestions.Count == 0)
            _remainingQuestions = [.._questions];
        Random rand = new Random();
        int index = rand.Next(0, _remainingQuestions.Count);
        string question = _remainingQuestions[index];
        _remainingQuestions.RemoveAt(index);
        return question;
    }

    private void DisplayPrompt()
    {
        Console.Write($" --- ");
        Console.Write(GetRandomPrompt());
        Console.Write(" --- ");
    }

    private void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(8);
    }
}
// A class called Jobs which holds information about each job such as company, job title, and the years.

// Lee Ward CSE210 June 30, 2026
using System;
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()      
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }   
}

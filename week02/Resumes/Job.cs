// A class called Jobs which holds information about each job such as company, job title, and the years.

// Steve Ward CSE210 March 2, 2026
using System;
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()      
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
}
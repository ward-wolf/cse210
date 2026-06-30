// A class called Jobs which holds information about each job such as company, job title, and the years.

// Lee Ward CSE210 June 30, 2026
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
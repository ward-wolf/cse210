// Program to run the Homework program

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create assignment object
        Assignment a1 = new Assignment("Joseph Smith", "Multiplication");
        Console.WriteLine(a1.GetSummary());
    
        // Create MathAssignment object
        MathAssignment m1 = new MathAssignment("Joseph Smith", "Multiplication", "6.1", "1-12");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.HomeworkList());

        //Create WritingAssignment object
        WritingAssignment w1 = new WritingAssignment("Joseph Smith", "Ancient History", "Peoples of the Ancient Americas");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}
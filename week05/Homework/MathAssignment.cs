// A child class MathAssignment from Parent class Assignment, MathAssignment has the textbook section and problems

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Constructor for MathAssignment
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    } 

    //Get HomeworkList 

    public string HomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}   
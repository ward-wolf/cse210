// A child class WritingAssignment from parent class Assignment. Includes title and has a GetWritingInformation. 

public class WritingAssignment : Assignment
{
    private string _title;  

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        
        return $"{_title} by {studentName}";
    }
}
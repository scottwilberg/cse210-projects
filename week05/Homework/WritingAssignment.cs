using System.Dynamic;

public class WritingAssignment : Assignment
{
    // objects for this class
    private string _title;
    // constructor class to get the info for this class and the parent class
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    // method to get the writing info for this class
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}
public class Assignment
{
    // made objects protected so I can access them with the child classes
    protected string _studentName;
    protected string _topic;
    // created a constructor class
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    // a class to get a summary of the objects
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
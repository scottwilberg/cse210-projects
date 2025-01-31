public class MathAssignment : Assignment
{
    // objects for this class
    private string _textbookSection;
    private string _problems;
    // constructor class for this class with the parent class info
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    // class to get the homework list
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
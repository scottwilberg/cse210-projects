public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    // constructor method for this class
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    // a method to return the name
    public string GetShortName()
    {
        return _shortName;
    }
    // a method to return the description
    protected string GetDescription()
    {
        return _description;
    }
    // a method to get the points
    public int GetPoints()
    {
        return _points;
    }
    // abstract methods to be defined by each child class
    public abstract void RecordEvent();
    // abstract methods to be defined by each child class
    public abstract bool IsComplete();
    // a virtual method since ony one chaild class alters it
    public virtual string GetDetailsString()
    {
        return $"{GetShortName()} ({GetDescription()})";
    }
    // abstract methods to be defined by each child class
    public abstract string GetStringRepresentation();
}
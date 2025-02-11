// set up a simple goal class
public class SimpleGoal : Goal
{
    private bool _isComplete;
    // created a constructor for simple goal and defined isComplete as false
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    // set isComplete to true when an event takes place
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    // method to return the status of is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }
    // method to set up how the string will be created for saving to a file
    public override string GetStringRepresentation()
    {
        return $"Simple Goal:{GetShortName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }
}
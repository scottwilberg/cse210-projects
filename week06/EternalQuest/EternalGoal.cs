public class EternalGoal : Goal
{
    // a constructor method for this class
   public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    // record event will be blank for eternal goals
    public override void RecordEvent()
    {
    }
    // method to return the status of is complete
    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete.
    }
    // method to set up how the string will be created for saving to a file
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal:{GetShortName()},{GetDescription()},{GetPoints()}";
    }
}
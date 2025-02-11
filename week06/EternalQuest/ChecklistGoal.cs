using System.Runtime;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    // set up the constructor method and set the amount complete to 0 and allowed the method to get the target and bonus
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    // a method to return the bonus
    public int GetBonus()
    {
        return _bonus;
    }
    // method to add to the amount complete for this class
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    // method to set up how the string will be created for saving to a file
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal:{GetShortName()},{GetDescription()},{GetPoints()},{IsComplete()},{_bonus},{_target},{_amountCompleted}";
    }
    public override string GetDetailsString()
    {
        return $"{GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
}
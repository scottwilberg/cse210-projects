public class SwimmingActivity : Activity
{
    private double _lap;
    public SwimmingActivity(string name, double length, double duration, double lap) : base(name, length, duration)
    {
        _lap = lap;
    }
    public override double GetDistance()
    {
        return _lap * 50 / 1000; // Distance in kilometers
    }
    public override double GetPace()
    {
        return GetDuration() / GetDistance(); // Pace in minutes per kilometer
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60; // Speed in kilometers per hour
    }

}
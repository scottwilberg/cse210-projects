public class CyclingActivity : Activity
{
    public CyclingActivity(string name, double length, double duration) : base(name, length, duration)
    {
        
    }
    public override double GetDistance()
    {
        return GetLength(); // Distance in kilometers
    }
    public override double GetPace()
    {
        return GetDuration() / GetLength(); // Pace in hours per kilometer
    }
    public override double GetSpeed()
    {
        return GetLength() / GetDuration(); // Speed in kilometers per hour
    }

}
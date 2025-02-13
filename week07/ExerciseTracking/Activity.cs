public abstract class Activity
{
    private string _name;
    private double _length;
    private double _duration;
    private DateTime _date;
    public Activity(string name, double length, double duration)
    {
        _name = name;
        _length = length;
        _duration = duration;
        _date = DateTime.Now; // Initialize _date to the current date and time
    }
    public double GetDuration()
    {
        return _duration;
    }
    public double GetLength()
    {
        return _length;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {_name} ({_duration} min): Distance: {GetDistance()} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace()} min per km";
    }
}
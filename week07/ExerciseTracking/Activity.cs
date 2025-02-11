public abstract class Activity
{
    private string _summary;
    public abstract void GetDistance();
    public abstract void GetSpeed();
    public abstract void GetPace();
    public string GetSummary()
    {
        return _summary;
    }
}
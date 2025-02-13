using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity("Running", 5, 30),
            new CyclingActivity("Cycling", 20, 60),
            new SwimmingActivity("Swimming", 1, 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
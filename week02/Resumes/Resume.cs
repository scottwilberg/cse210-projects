using System;
public class Resume
{
    public string _owner;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_owner}");
        Console.WriteLine("Job: ");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetail();
        }
    }
}
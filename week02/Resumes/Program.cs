using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1991;
        job1._endYear = 2003;
        
        Job job2 = new Job();
        job2._company = "Verizon";
        job2._jobTitle = "Sales Person";
        job2._startYear = 2003;
        job2._endYear = 2024;

        job1.DisplayJobDetail();

        job2.DisplayJobDetail();

        Resume myResume = new Resume();
        myResume._owner = "Scott Wilberg";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}